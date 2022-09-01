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
    public class Renderer
    {
        public static void Render(Dictionary<(int, int), char> matrices, int rowCount, int colCount, int startX, int startY)
        {
            if ((startX > -1) && (startY > -1))
                Console.SetCursorPosition(startX, startY);

            StringBuilder sb = new StringBuilder();

            sb.Append("      +");
            for (int c = 0; c < colCount; c++)
                sb.Append("-----+");
            sb.Append("\n      |");
            for (int c = 0; c < colCount; c++)
                sb.Append("     |");
            sb.Append("\n     C|");
            for (int c = 0; c < colCount; c++)
                sb.AppendFormat("  {0}  |", c + 1);
            sb.Append("\n   R  |");
            for (int c = 0; c < colCount; c++)
                sb.Append("     |");
            sb.Append("\n");

            for (int r = 0; r < rowCount; r++)
            {
                sb.Append("+-----+");
                for (int c = 0; c < colCount; c++)
                    sb.Append("-----+");
                sb.Append("\n|     |");
                for (int c = 0; c < colCount; c++)
                    sb.Append("     |");
                sb.AppendFormat("\n|  {0}  |", r + 1);
                for (int c = 0; c < colCount; c++)
                {
                    if (!matrices.ContainsKey((r, c)))
                        throw new ArgumentException(String.Format("Unavailable matrix indexes [{0},{1}].", r, c));
                    sb.AppendFormat("  {0}  |", matrices[(r, c)]);
                }
                sb.Append("\n|     |");
                for (int c = 0; c < colCount; c++)
                    sb.Append("     |");
                sb.Append("\n");
            }

            sb.Append("+-----+");
            for (int c = 0; c < colCount; c++)
                sb.Append("-----+");
            sb.Append("\n");

            Console.WriteLine(sb.ToString());
        }

        public static void Render(Dictionary<(int, int), char> matrices, int rowCount, int colCount)
        {
            Render(matrices, rowCount, colCount, -1, -1);
        }
    }
}