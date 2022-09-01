// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.TicTacToe.Game
{
    public class CommandMenu
    {
        public string MainMenu { get; set; } = "MAIN MENU";

        public string MenuQuestion { get; set; } = "Choose an option : ";

        public string DefaultOption { get; set; } = String.Empty;

        private Dictionary<string, Tuple<string, Action>> _Options;

        private bool _OutOfLoop = false;

        public CommandMenu()
        {
            _Options = new Dictionary<string, Tuple<string, Action>>();
        }

        public CommandMenu Add(string key, string text, Action action)
        {
            _Options.Add(key.ToLower(), Tuple.Create(text, action));
            return this;
        }

        public CommandMenu Add(string key, string text, Action action, bool isDefault)
        {
            _Options.Add(key.ToLower(), Tuple.Create(text, action));
            if (isDefault)
                DefaultOption = key.ToLower();
            return this;
        }

        public CommandMenu AddExitItem(string key, string text, bool isDefault)
        {
            string aKey = key.ToLower();
            if (_Options.ContainsKey(aKey))
                _Options.Remove(aKey);
            _Options.Add(aKey, Tuple.Create(text, () =>
            {
                _OutOfLoop = true;
            }));
            if (isDefault)
                DefaultOption = aKey;
            return this;
        }

        public void GoOutOfLoop()
        {
            _OutOfLoop = true;
        }

        public void Run()
        {
            _OutOfLoop = false;
            if (_Options.Count <= 0)
                return;

            while (!_OutOfLoop)
            {
                Console.WriteLine(MainMenu);
                foreach (var opt in _Options)
                {
                    Console.WriteLine("{0}) {1}", opt.Key, opt.Value.Item1);
                }
                Console.Write(MenuQuestion);
                if (DefaultOption != String.Empty)
                    Console.Write("[{0}] ", DefaultOption);

                string selectedOpt = Console.ReadLine()!.ToLower();
                if (DefaultOption != String.Empty)
                    if (selectedOpt == String.Empty)
                        selectedOpt = DefaultOption;

                if (_Options.ContainsKey(selectedOpt))
                {
                    var opt = _Options[selectedOpt];
                    opt.Item2.Invoke();
                }
            }
        }
    }
}