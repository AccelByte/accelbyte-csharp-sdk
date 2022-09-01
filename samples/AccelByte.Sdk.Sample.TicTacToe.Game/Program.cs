// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api.Lobby;
using AccelByte.Sdk.Api.Lobby.WSModel;

namespace AccelByte.Sdk.Sample.TicTacToe.Game
{
    internal class Program
    {
        static volatile bool _InGame = false;

        static volatile bool _GameEnd = false;

        static int _BoardSize = 0;

        static bool SelectAndJoinMatch(Player player)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            List<string> matchIds = player.GetAvailableMatches();
            if (matchIds.Count <= 0)
                return false;

            for (int i=0;i<matchIds.Count;i++)
                Console.WriteLine("[{0}] {1}", i + 1, matchIds[i]);

            int tIndex = 0;
            while (true)
            {
                Console.Write("Select match [1 - {0}]: ", matchIds.Count);
                string? selection = Console.ReadLine();
                if (selection == null)
                    continue;

                if (!int.TryParse(selection.Trim(), out tIndex))
                {
                    Console.WriteLine("Invalid value");
                    continue;
                }
                
                if ((tIndex < 1) || (tIndex > matchIds.Count))
                {
                    Console.WriteLine("Selection is out of bounds.");
                    continue;
                }

                break;
            }

            string selectedMatchId = matchIds[tIndex - 1];
            player.JoinGame(selectedMatchId);

            return true;
        }

        static void GameInput(Player player)
        {
            while (true)
            {
                if (_InGame)
                {
                    int iRow = -1;
                    int iCol = -1;

                    while (true)
                    {
                        string? iValue = Console.ReadLine();
                        if (iValue == null)
                        {
                            Console.WriteLine("value is null. ");
                            continue;
                        }

                        string[] parts = iValue.Split(',', 2, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                        if (parts.Length != 2)
                        {
                            Console.WriteLine("Invalid format. ");
                            continue;
                        }

                        if (!int.TryParse(parts[0], out iRow))
                        {
                            Console.WriteLine("Invalid integer format for row. ");
                            continue;
                        }

                        if ((iRow < 1) || (iRow > _BoardSize))
                        {
                            Console.WriteLine("Specified row is out of bounds. ");
                            continue;
                        }

                        if (!int.TryParse(parts[1], out iCol))
                        {
                            Console.WriteLine("Invalid integer format for column. ");
                            continue;
                        }

                        if ((iCol < 1) || (iCol > _BoardSize))
                        {
                            Console.WriteLine("Specified column is out of bounds. ");
                            continue;
                        }

                        break;
                    }

                    _InGame = false;
                    player.MakeAMove(iRow - 1, iCol - 1);
                }
                else if (_GameEnd)
                {
                    break;
                }
            }
        }

        static int Main(string[] args)
        {
            _InGame = false;

            Player? player = null;
            try
            {
                CommandArguments cArgs = new CommandArguments(args);
                player = new Player(cArgs)
                {
                    OnMatchStarted = (m, b) =>
                    {
                        _BoardSize = m.BoardSize;

                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Player 1: {0}", m.P1Name);
                        Console.WriteLine("Player 2: {0}", m.P2Name);

                        Renderer.Render(b, m.BoardSize, m.BoardSize);

                        _GameEnd = false;
                        if (m.IsPlayerTurn)
                        {
                            _InGame = true;
                            Console.Write("Input your move [row,col]: ");
                        }
                        else
                        {
                            _InGame = false;
                            Console.Write("Other player's Turn.");
                        }
                    },
                    OnMatchUpdated = (m, b) =>
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Player 1: {0}", m.P1Name);
                        Console.WriteLine("Player 2: {0}", m.P2Name);

                        Renderer.Render(b, m.BoardSize, m.BoardSize);

                        if (m.IsPlayerTurn)
                        {
                            _InGame = true;
                            Console.Write("Input your move [row,col]: ");
                        }
                        else
                        {
                            _InGame = false;
                            Console.Write("Other player's Turn.");
                        }
                    },
                    OnMatchConcluded = (m, winner) =>
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Player 1: {0}", m.P1Name);
                        Console.WriteLine("Player 2: {0}", m.P2Name);
                        Console.WriteLine();
                        if (winner)
                            Console.WriteLine("YOU ARE THE WINNER");
                        else
                            Console.WriteLine("YOU ARE LOSE!");

                        _InGame = false;
                        _GameEnd = true;
                    }
                };

                (new CommandMenu())
                    .Add("1", "Login", () =>
                    {
                        try
                        {
                            bool b = false;
                            if (!player.IsCredentialAvailable)
                            {
                                string aUsername = cArgs.LoginUsername;
                                if (aUsername == String.Empty)
                                {
                                    Console.Write("Username? ");
                                    aUsername = Console.ReadLine()!.Trim();
                                }

                                string aPassword = cArgs.LoginPassword;
                                if (aPassword == String.Empty)
                                {
                                    Console.Write("Password? ");
                                    aPassword = Console.ReadLine()!.Trim();
                                }

                                b = player.Login(aUsername, aPassword);
                            }
                            else
                                b = player.Login();
                            if (!b)
                                throw new Exception("failed");
                        }
                        catch (Exception x)
                        {
                            Console.WriteLine("Login error: {0}", x.Message);
                        }
                    })
                    .Add("2", "Start Game", () =>
                    {
                        player.NewGame();

                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Waiting for other player to join...");

                        GameInput(player);
                    })
                    .Add("3","Join Game", () =>
                    {
                        if (SelectAndJoinMatch(player))
                            GameInput(player);
                        else
                        {
                            Console.WriteLine("No available match(es). Press enter to go back to menu.");
                            Console.ReadLine();
                        }
                    })
                    .AddExitItem("x", "Exit", true)
                    .Run();

                player.Disconnect();
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
                player?.Disconnect();
                return 2;
            }
        }
    }
}