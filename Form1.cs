using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cargo> _csvStruct = new List<Cargo>();
        public string name;
        public string namedate;


        public string sl = "Запыленность в трубе", s2;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sl = comboBox1.SelectedItem.ToString();
            mygraf();
        }


        public void mygraf()
        {
            if (sl == "Разр_Ф_1_1")
            {
                //chart1.Invalidate();
                myclear();
                chart1.ChartAreas[0].AxisY.Title = "Кпа";
                
                chart1.Titles.Add("Разр_Ф_1_1     " + namedate);
                chart1.Series[0].LegendText = "Разрежение_перед_Ф1_1";
                chart1.Series[1].LegendText = "Разрежение_после_Ф1_1";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 7;


                


                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, Convert.ToDouble(_csvStruct[i].P211));
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, Convert.ToDouble(_csvStruct[i].P212));


                }
                chart1.Refresh();
            }
            if (sl == "Разр_Ф_1_2")
            {

                myclear();
                chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "Кпа";
                chart1.Titles.Add("Разр_Ф_1_2     " + namedate);
                chart1.Series[0].LegendText = "Разрежение_перед_Ф1_2";
                chart1.Series[1].LegendText = "Разрежение_после_Ф1_2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 7;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].P212);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].P222);


                }
                chart1.Refresh();
            }
            if (sl == "Переп_Разр_Ф_1_1")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "Кпа";
                chart1.Titles.Add("Переп_Разр_Ф_1_1     " + namedate);
                chart1.Series[0].LegendText = "Перепад_разрежения_Смеси_на_Ф1_1";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 7;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].DPsa231);



                }
                chart1.Refresh();

            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Переп_Разр_Ф_1_2")
            {

                myclear();
                chart1.ChartAreas[0].AxisY.Title = "Кпа";
                //chart1.Invalidate();
                chart1.Titles.Add("Переп_Разр_Ф_1_2     " + namedate);
                chart1.Series[0].LegendText = "Перепад_разрежения_Смеси_на_Ф1_2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 7;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].DPsa232);



                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Темпер_Ф_1_1")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Темпер_Ф_1_1     " + namedate);
                chart1.Series[0].LegendText = "Темпер_Ф_1_1";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].T11);



                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Темпер_Ф_1_2")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Темпер_Ф_1_2     " + namedate);
                chart1.Series[0].LegendText = "t_Смеси_перед_Ф1_2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].T21);



                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Циклоны.Запыленность")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°мг/м³";
                chart1.Titles.Add("Циклоны.Запыленность     " + namedate);
                chart1.Series[0].LegendText = "Запылён_в_Ф1_1";
                chart1.Series[1].LegendText = "Запылён_в_Ф1_2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 40;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Q821);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Q822);



                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Компр давл")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "Мпа";
                chart1.Titles.Add("Компр давл     " + namedate);
                chart1.Series[0].LegendText = "Р_Компр_1_1";
                chart1.Series[1].LegendText = "Р_Компр_1_2";
                chart1.Series[2].LegendText = "Р.Компр.№2";
                chart1.Series[3].LegendText = "Р_осуш_возд_до_рег_клап";
                chart1.Series[4].LegendText = "Р_осуш_возд_после_рег_клап";
                chart1.Series[5].LegendText = "Р_осуш_возд_в_сборн_Е1_1";
                chart1.Series[6].LegendText = "Р_осуш_возд_в_сборн_Е1_2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = true;
                chart1.Series[5].IsVisibleInLegend = true;
                chart1.Series[6].IsVisibleInLegend = true;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 1;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Pa24);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Pa25);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Pa26);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Pa30);
                    chart1.Series[4].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Pa27);
                    chart1.Series[5].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Pa28);
                    chart1.Series[6].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Pa29);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Компр расход")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "м³/ч";
                chart1.Titles.Add("Компр расход     " + namedate);
                chart1.Series[0].LegendText = "Расход_сжат_осуш_возд_на_реген_ф_1_1";
                chart1.Series[1].LegendText = "Расход_сжат_осуш_возд_на_реген_ф_1_2";

                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 800;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].F311);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].F312);


                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Компр темпер")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Компр темпер     " + namedate);
                chart1.Series[0].LegendText = "Темп_возд_в_компр_т_1";
                chart1.Series[1].LegendText = "Темп_возд_в_компр_т_2";
                chart1.Series[2].LegendText = "t_перед_осушит_С1_1,С1_2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].T2011);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].T2012);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].T3);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Насосы")
            {

                myclear();
                chart1.ChartAreas[0].AxisY.Title = "м";
                //chart1.Invalidate();
                chart1.Titles.Add("Насосы     " + namedate);
                chart1.Series[0].LegendText = "L_шл_ст_в_приёмн_рез";

                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 5;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Lsa301);


                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Вент  температ")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Вент  температ     " + namedate);
                chart1.Series[0].LegendText = "t_Прит_возд_В_с_мы_В1";
                chart1.Series[1].LegendText = "t_Прит_возд_В_с_мы_В2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tcs2021);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tcs2022);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Вент разреж")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "Мпа";
                chart1.Titles.Add("Вент разреж     " + namedate);
                chart1.Series[0].LegendText = "% разр.возд.фильтра П1/1";
                chart1.Series[1].LegendText = "% разр.возд.фильтра П1/2";
                chart1.Series[2].LegendText = "% разр.возд.фильтра П2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 20;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].DPa2111);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].DPa2112);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].DPa212);
                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Вент_03_Полож")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "Мпа";
                chart1.Titles.Add("Вент_03_Полож     " + namedate);
                chart1.Series[0].LegendText = "Положение привода AF24-SR клапана КВУ П 1.1 точка 1";
                chart1.Series[1].LegendText = "Положение привода AF24-SR клапана КВУ П 1.1 точка 2";
                chart1.Series[2].LegendText = "Положение привода AF24-SR клапана КВУ П 1.2 точка 1";
                chart1.Series[3].LegendText = "Положение привода AF24-SR клапана КВУ П 1.2 точка 2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 100;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gtcv20211);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gtcv20212);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gtcv20221);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gtcv20222);
                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Запыленность в трубе")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "мг/м³";
                chart1.Titles.Add("Запыленность в трубе     " + namedate);
                chart1.Series[0].LegendText = "запылён_в_трубе";

                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 30;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Q81);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д_Д1")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "А";
                chart1.Titles.Add("Д_Д1     " + namedate);
                chart1.Series[0].LegendText = "Положение клапана КЛ-5";
                chart1.Series[1].LegendText = "Положение клапана КЛ-6";
                chart1.Series[2].LegendText = "Положение клапана КЛ-11";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 110;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz115);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz116);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz121);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д1 ток привода")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "А";
                chart1.Titles.Add("Д1 ток привода     " + namedate);
                chart1.Series[0].LegendText = "ТОК НАГР.ДВ № 1";

                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 300;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ei201);


                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д1 температура подш")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Д1 температура подш     " + namedate);
                chart1.Series[0].LegendText = "t_подш_1";
                chart1.Series[1].LegendText = "t_подш_2";
                chart1.Series[2].LegendText = "t_подш_3";
                chart1.Series[3].LegendText = "t_подш_4";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa71);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa72);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa41);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa42);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д1 температура двигателя")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Д1 температура двигателя     " + namedate);
                chart1.Series[0].LegendText = "t_обмотки_ф_А_1";
                chart1.Series[1].LegendText = "t_активного_железа_ф_А_2";
                chart1.Series[2].LegendText = "t_обмотки_ф_В_3";
                chart1.Series[3].LegendText = "t_активного_железа_ф_В_4";
                chart1.Series[4].LegendText = "t_обмотки_ф_С_5";
                chart1.Series[5].LegendText = "t_активного_железа_ф_С_6";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = true;
                chart1.Series[5].IsVisibleInLegend = true;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa101);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa102);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa103);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa104);
                    chart1.Series[4].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa105);
                    chart1.Series[5].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa106);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д1 вибрация")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "мм/с";
                chart1.Titles.Add("Д1 вибрация     " + namedate);
                chart1.Series[0].LegendText = "Верт_вибр_эл_дв_Д1";
                chart1.Series[1].LegendText = "Верт_вибр_подш_3_Дым_Д1";
                chart1.Series[2].LegendText = "Гор_вибр_подш_3_Дым_Д1";
                chart1.Series[3].LegendText = "Осев_вибр_подш_3_Дым_Д1";
                chart1.Series[4].LegendText = "Верт_вибр_подш_4_Дым_Д1";
                chart1.Series[5].LegendText = "Гор_вибр_подш_4_Дым_Д1";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = true;
                chart1.Series[5].IsVisibleInLegend = true;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Maximum = 20;
                chart1.ChartAreas[0].AxisY.Minimum = 0;

                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa61);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa64);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa67);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa70);
                    chart1.Series[4].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa73);
                    chart1.Series[5].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa76);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д_Д2")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "мм/с";
                chart1.Titles.Add("Д_Д2     " + namedate);
                chart1.Series[0].LegendText = "Положение клапана КЛ-7";
                chart1.Series[1].LegendText = "Положение клапана КЛ-8";
                chart1.Series[2].LegendText = "Положение клапана КЛ-12";

                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 110;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz117);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz118);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz122);


                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д2 ток привода")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "A";
                chart1.Titles.Add("Д2 ток привода     " + namedate);
                chart1.Series[0].LegendText = "ТОК НАГР.ДВ № 2";


                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 300;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ei202);



                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д2 температура подш")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Д2 температура подш     " + namedate);
                chart1.Series[0].LegendText = "t_подш_1";
                chart1.Series[1].LegendText = "t_подш_2";
                chart1.Series[2].LegendText = "t_подш_3";
                chart1.Series[3].LegendText = "t_подш_4";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa81);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa82);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa51);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa52);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д2 температура двигателя")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Д2 температура двигателя     " + namedate);
                chart1.Series[0].LegendText = "t_обмотки_ф_А_1";
                chart1.Series[1].LegendText = "t_активного_железа_ф_А_2";
                chart1.Series[2].LegendText = "t_обмотки_ф_В_3";
                chart1.Series[3].LegendText = "t_активного_железа_ф_В_4";
                chart1.Series[4].LegendText = "t_обмотки_ф_С_5";
                chart1.Series[5].LegendText = "t_активного_железа_ф_С_6";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = true;
                chart1.Series[5].IsVisibleInLegend = true;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa111);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa112);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa113);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa114);
                    chart1.Series[4].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa115);
                    chart1.Series[5].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa116);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д2 вибрация")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "мм/с";
                chart1.Titles.Add("Д2 вибрация     " + namedate);
                chart1.Series[0].LegendText = "Верт_вибр_эл_дв_Д2";
                chart1.Series[1].LegendText = "Верт_вибр_подш_3_Дым_Д2";
                chart1.Series[2].LegendText = "Гор_вибр_подш_3_Дым_Д2";
                chart1.Series[3].LegendText = "Осев_вибр_подш_3_Дым_Д2";
                chart1.Series[4].LegendText = "Верт_вибр_подш_4_Дым_Д2";
                chart1.Series[5].LegendText = "Гор_вибр_подш_4_Дым_Д2";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = true;
                chart1.Series[5].IsVisibleInLegend = true;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 20;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa62);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa65);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa68);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa71);
                    chart1.Series[4].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa74);
                    chart1.Series[5].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa77);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д_Д3")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "мм/с";
                chart1.Titles.Add("Д_Д3     " + namedate);
                chart1.Series[0].LegendText = "Положение клапана КЛ-9";
                chart1.Series[1].LegendText = "Положение клапана КЛ-10";
                chart1.Series[2].LegendText = "Положение клапана КЛ-13";

                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 110;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz119);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz120);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Gz123);


                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д3 ток привода")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "A";
                chart1.Titles.Add("Д3 ток привода     " + namedate);
                chart1.Series[0].LegendText = "ТОК НАГР.ДВ № 3";


                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = false;
                chart1.Series[2].IsVisibleInLegend = false;
                chart1.Series[3].IsVisibleInLegend = false;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 300;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ei203);



                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д3 температура подш")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Д3 температура подш     " + namedate);
                chart1.Series[0].LegendText = "t_подш_1";
                chart1.Series[1].LegendText = "t_подш_2";
                chart1.Series[2].LegendText = "t_подш_3";
                chart1.Series[3].LegendText = "t_подш_4";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = false;
                chart1.Series[5].IsVisibleInLegend = false;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa91);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa92);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa61);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa62);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д3 температура двигателя")
            {

                myclear();
                chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "°С";
                chart1.Titles.Add("Д3 температура двигателя     " + namedate);
                chart1.Series[0].LegendText = "t_обмотки_ф_А_1";
                chart1.Series[1].LegendText = "t_активного_железа_ф_А_2";
                chart1.Series[2].LegendText = "t_обмотки_ф_В_3";
                chart1.Series[3].LegendText = "t_активного_железа_ф_В_4";
                chart1.Series[2].LegendText = "t_обмотки_ф_С_5";
                chart1.Series[3].LegendText = "t_активного_железа_ф_С_6";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = true;
                chart1.Series[5].IsVisibleInLegend = true;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 150;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa121);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa122);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa123);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa124);
                    chart1.Series[4].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa125);
                    chart1.Series[5].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Tsa126);

                }
                chart1.Refresh();

            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "Д3 вибрация")
            {

                myclear();
                //chart1.Invalidate();
                chart1.ChartAreas[0].AxisY.Title = "мм/с";
                chart1.Titles.Add("Д3 вибрация     " + namedate);
                chart1.Series[0].LegendText = "Верт_вибр_эл_дв_Д3";
                chart1.Series[1].LegendText = "Верт_вибр_подш_3_Дым_Д3";
                chart1.Series[2].LegendText = "Гор_вибр_подш_3_Дым_Д3";
                chart1.Series[3].LegendText = "Осев_вибр_подш_3_Дым_Д3";
                chart1.Series[2].LegendText = "Верт_вибр_подш_4_Дым_Д3";
                chart1.Series[3].LegendText = "Гор_вибр_подш_4_Дым_Д3";
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;
                chart1.Series[4].IsVisibleInLegend = true;
                chart1.Series[5].IsVisibleInLegend = true;
                chart1.Series[6].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 20;
                for (int i = 0; i < _csvStruct.Count; i++)
                {


                    chart1.Series[0].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa63);
                    chart1.Series[1].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa66);
                    chart1.Series[2].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa69);
                    chart1.Series[3].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa72);
                    chart1.Series[4].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa75);
                    chart1.Series[5].Points.AddXY(_csvStruct[i].Time, _csvStruct[i].Ssa78);

                }
                chart1.Refresh();

            }

            ////////////////////////////////////////////////////////////////////////////////////////////
            if (sl == "test")
            {
                myclear();
                DateTime time = DateTime.Parse("00:00:00");


                for (int i = 0; i <= 8640; i++)
                {
                    time.AddSeconds(i);
                    chart1.Series[0].Points.AddXY(time, 5);
                    

                }
            }
        }




        public void myclear()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
            chart1.Titles.Clear();
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = comboBox2.SelectedItem.ToString();
            _csvStruct = Cargo.ReadFile(string.Format(@"d:\Work\{0}.csv", s2));


            namedate = s2.Substring(0, 10);


            mygraf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            
            string[] files = System.IO.Directory.GetFiles(@"d:\Work\", "*csv");
            int i = 0, j = 0;
            string mys;
            //Array.Sort(files, 3, 1);

            foreach (var file in files)
            {
                mys = file.Substring(8, 10);
                comboBox2.Items.Add(Path.GetFileName(file.Substring(8, 10)));
                if (mys == DateTime.Today.ToShortDateString())
                {
                    j = i;
                }
                i++;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = 8640;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 360;
                





            }
            
            comboBox2.Sorted = true;
            //comboBox2.FindString();
            
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = j;
            

        }

        


    }

}
