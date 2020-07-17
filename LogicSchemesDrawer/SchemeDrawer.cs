using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSchemesDrawer
{
    public class SchemeDrawer
    {
        private const int andCoordX = 400;
        private const int bigAndCoordX = 700;
        private List<int> notCoordsY = new List<int>();

        public void DrawScheme(Graphics g, int[,] minForm, int boxWidth, int boxHeight)
        {
            // желтый фон
            SolidBrush br = new SolidBrush(Color.FromArgb(255, 227, 127));
            g.FillRectangle(br, 0, 0, boxWidth, boxHeight);
            Pen pen = new Pen(Color.Black, 2);
            // каркас
            DrawStringVars(g, 10, 10, minForm.GetUpperBound(1));
            DrawVarLines(g, 15, 40, minForm.GetUpperBound(1));
            // горизонтальные линии и блоки И-НЕ
            int rows = minForm.GetUpperBound(0) + 1;
            int cols = minForm.Length / rows;
            int cursPosX = 15;
            int cursPosY = 100;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 0)
                    {
                        DrawAndNot(g, andCoordX + 5, cursPosY);
                    }
                    switch (minForm[i, j])
                    {
                        case 1:
                            DrawPoint(g, cursPosX, cursPosY);
                            g.DrawLine(pen, cursPosX, cursPosY, andCoordX, cursPosY);
                            break;
                        case 0:
                            DrawPoint(g, cursPosX + 20, cursPosY);
                            g.DrawLine(pen, cursPosX + 20, cursPosY, andCoordX, cursPosY);
                            break;
                        default:
                            break;
                    }
                    cursPosY += 7;
                    cursPosX += 65;
                }
                cursPosX = 15;
                cursPosY += 20;
            }
            // большой блок И-НЕ
            int bigAndNotCoordY = cursPosY - (cursPosY - 100) / 2;
            int notCoordX = 480;
            foreach (var i in notCoordsY)
            {
                g.DrawLine(pen, notCoordX, i, bigAndCoordX, bigAndNotCoordY);
            }
            DrawBigAndNot(g, bigAndCoordX - 20, bigAndNotCoordY);
            pen.Dispose();
        }

        private void DrawInvertorDown(Graphics g, int x, int y)
        {
            SolidBrush br = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black, 2);
            g.FillRectangle(br, x - 7, y - 10, 14, 20);
            g.DrawRectangle(pen, x - 7, y - 10, 14, 20);
            g.FillEllipse(br, x - 3, y + 7, 6, 6);
            g.DrawEllipse(pen, x - 3, y + 7, 6, 6);
        }

        private void DrawInvertorRight(Graphics g, int x, int y)
        {
            SolidBrush br = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black, 2);
            g.FillRectangle(br, x - 10, y - 7, 20, 14);
            g.DrawRectangle(pen, x - 10, y - 7, 20, 14);
            g.FillEllipse(br, x + 7, y - 3, 6, 6);
            g.DrawEllipse(pen, x + 7, y - 3, 6, 6);
        }

        private void DrawAndNot(Graphics g, int x, int y)
        {
            SolidBrush br = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black, 2);
            g.FillRectangle(br, x - 5, y - 10, 30, 40);
            g.DrawRectangle(pen, x - 5, y - 10, 30, 40);
            string andSymb = "&";
            SolidBrush brText = new SolidBrush(Color.Black);
            Font roman = new Font("Times New Roman", 14, FontStyle.Bold);
            g.DrawString(andSymb, roman, brText, x, y);
            g.DrawLine(pen, x + 25, y + 10, x + 60, y + 10);
            DrawInvertorRight(g, x + 60, y + 10);
            notCoordsY.Add(y + 10);
        }

        private void DrawBigAndNot(Graphics g, int x, int y)
        {
            SolidBrush br = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black, 2);
            g.FillRectangle(br, x - 30, y - 40, 60, 80);
            g.DrawRectangle(pen, x - 30, y - 40, 60, 80);
            string andSymb = "&";
            SolidBrush brText = new SolidBrush(Color.Black);
            Font roman = new Font("Times New Roman", 22, FontStyle.Bold);
            g.DrawString(andSymb, roman, brText, x - 15, y - 20);
            g.DrawLine(pen, x + 30, y, x + 90, y);
            DrawInvertorRight(g, x + 60, y);
            roman = new Font("Times New Roman", 16);
            g.DrawString("F", roman, brText, x + 100, y - 15);
        }

        private void DrawStringVars(Graphics g, int x, int y, int varsCount)
        {
            SolidBrush brText = new SolidBrush(Color.Black);
            string vars;
            switch (varsCount + 1)
            {
                case 2:
                    vars = "x           y";
                    break;
                case 3:
                    vars = "x           y           z";
                    break;
                case 4:
                    vars = "x           y           z           w";
                    break;
                default:
                    vars = "ПРОИЗОШЛА ОШИБКА";
                    break;
            }
            Font roman = new Font("Times New Roman", 14);
            g.DrawString(vars, roman, brText, x, y);
        }

        private void DrawPoint(Graphics g, int x, int y)
        {
            SolidBrush brPoint = new SolidBrush(Color.Black);
            g.FillEllipse(brPoint, x - 4, y - 4, 8, 8);
        }

        private void DrawVarLines(Graphics g, int x, int y, int varsCount)
        {
            Pen pen = new Pen(Color.Black, 2);
            int posX = x;
            for (int i = 0; i < varsCount + 1; i++)
            {
                g.DrawLine(pen, posX, y, posX, y + 850);
                DrawPoint(g, posX, y + 15);
                g.DrawLine(pen, posX, y + 15, posX + 20, y + 15);
                g.DrawLine(pen, posX + 20, y + 15, posX + 20, y + 850);
                DrawInvertorDown(g, posX + 20, y + 30);
                posX += 65;
            }
            pen.Dispose();
        }        
    }
}
