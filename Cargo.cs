using System.Collections.Generic;
using System.IO;
using System;

namespace WindowsFormsApplication1
{

    public class Cargo
    {
        public string Time { get; set; }
        public double P211 { get; set; }
        public double P221 { get; set; }
        public double P212 { get; set; }
        public double P222 { get; set; }
        public double DPsa231 { get; set; }
        public double DPsa232 { get; set; }
        public double T11 { get; set; }
        public double T21 { get; set; }
        public double Q821 { get; set; }
        public double Q822 { get; set; }
        public double Pa24 { get; set; }
        public double Pa25 { get; set; }
        public double Pa26 { get; set; }
        public double Pa30 { get; set; }
        public double Pa27 { get; set; }
        public double Pa28 { get; set; }
        public double Pa29 { get; set; }
        public double F311 { get; set; }
        public double F312 { get; set; }
        public double T2011 { get; set; }
        public double T2012 { get; set; }
        public double T3 { get; set; }
        public double Lsa301 { get; set; }
        public double Tcs2021 { get; set; }
        public double Tcs2022 { get; set; }
        public double DPa2111 { get; set; }
        public double DPa2112 { get; set; }
        public double DPa212 { get; set; }
        public double Gtcv20211 { get; set; }
        public double Gtcv20212 { get; set; }
        public double Gtcv20221 { get; set; }
        public double Gtcv20222 { get; set; }
        public double Q81 { get; set; }
        public double Gz115 { get; set; }
        public double Gz116 { get; set; }
        public double Gz121 { get; set; }
        public double Ei201 { get; set; }
        public double Tsa71 { get; set; }
        public double Tsa72 { get; set; }
        public double Tsa41 { get; set; }
        public double Tsa42 { get; set; }
        public double Tsa101 { get; set; }
        public double Tsa102 { get; set; }
        public double Tsa103 { get; set; }
        public double Tsa104 { get; set; }
        public double Tsa105 { get; set; }
        public double Tsa106 { get; set; }
        public double Ssa61 { get; set; }
        public double Ssa64 { get; set; }
        public double Ssa67 { get; set; }
        public double Ssa70 { get; set; }
        public double Ssa73 { get; set; }
        public double Ssa76 { get; set; }
        public double Gz117 { get; set; }
        public double Gz118 { get; set; }
        public double Gz122 { get; set; }
        public double Ei202 { get; set; }
        public double Tsa81 { get; set; }
        public double Tsa82 { get; set; }
        public double Tsa51 { get; set; }
        public double Tsa52 { get; set; }
        public double Tsa111 { get; set; }
        public double Tsa112 { get; set; }
        public double Tsa113 { get; set; }
        public double Tsa114 { get; set; }
        public double Tsa115 { get; set; }
        public double Tsa116 { get; set; }
        public double Ssa62 { get; set; }
        public double Ssa65 { get; set; }
        public double Ssa68 { get; set; }
        public double Ssa71 { get; set; }
        public double Ssa74 { get; set; }
        public double Ssa77 { get; set; }
        public double Gz119 { get; set; }
        public double Gz120 { get; set; }
        public double Gz123 { get; set; }
        public double Ei203 { get; set; }
        public double Tsa91 { get; set; }
        public double Tsa92 { get; set; }
        public double Tsa61 { get; set; }
        public double Tsa62 { get; set; }
        public double Tsa121 { get; set; }
        public double Tsa122 { get; set; }
        public double Tsa123 { get; set; }
        public double Tsa124 { get; set; }
        public double Tsa125 { get; set; }
        public double Tsa126 { get; set; }
        public double Ssa63 { get; set; }
        public double Ssa66 { get; set; }
        public double Ssa69 { get; set; }
        public double Ssa72 { get; set; }
        public double Ssa75 { get; set; }
        public double Ssa78 { get; set; }



        //Метод для получения частей из строки
        public void Piece(string line)
        {
            //Array.Clear(parts, 0, parts.Length);

            var parts = line.Split(';');
            Time = parts[0];
            P211 = Convert.ToDouble(parts[1]);
            P221 = Convert.ToDouble(parts[2]);
            P212 = Convert.ToDouble(parts[3]);
            P222 = Convert.ToDouble(parts[4]);
            DPsa231 = Convert.ToDouble(parts[5]);
            DPsa232 = Convert.ToDouble(parts[6]);
            T11 = Convert.ToDouble(parts[7]);
            T21 = Convert.ToDouble(parts[8]);
            Q821 = Convert.ToDouble(parts[9]);
            Q822 = Convert.ToDouble(parts[10]);
            Pa24 = Convert.ToDouble(parts[11]);
            Pa25 = Convert.ToDouble(parts[12]);
            Pa26 = Convert.ToDouble(parts[13]);
            Pa30 = Convert.ToDouble(parts[14]);
            Pa27 = Convert.ToDouble(parts[15]);
            Pa28 = Convert.ToDouble(parts[16]);
            Pa29 = Convert.ToDouble(parts[17]);
            F311 = Convert.ToDouble(parts[18]);
            F312 = Convert.ToDouble(parts[19]);
            T2011 = Convert.ToDouble(parts[20]);
            T2012 = Convert.ToDouble(parts[21]);
            T3 = Convert.ToDouble(parts[22]);
            Lsa301 = Convert.ToDouble(parts[23]);
            Tcs2021 = Convert.ToDouble(parts[24]);
            Tcs2022 = Convert.ToDouble(parts[25]);
            DPa2111 = Convert.ToDouble(parts[26]);
            DPa2112 = Convert.ToDouble(parts[27]);
            DPa212 = Convert.ToDouble(parts[28]);
            Gtcv20211 = Convert.ToDouble(parts[29]);
            Gtcv20212 = Convert.ToDouble(parts[30]);
            Gtcv20221 = Convert.ToDouble(parts[31]);
            Gtcv20222 = Convert.ToDouble(parts[32]);
            Q81 = Convert.ToDouble(parts[33]);
            Gz115 = Convert.ToDouble(parts[34]);
            Gz116 = Convert.ToDouble(parts[35]);
            Gz121 = Convert.ToDouble(parts[36]);
            Ei201 = Convert.ToDouble(parts[37]);
            Tsa71 = Convert.ToDouble(parts[38]);
            Tsa72 = Convert.ToDouble(parts[39]);
            Tsa41 = Convert.ToDouble(parts[40]);
            Tsa42 = Convert.ToDouble(parts[41]);
            Tsa101 = Convert.ToDouble(parts[42]);
            Tsa102 = Convert.ToDouble(parts[43]);
            Tsa103 = Convert.ToDouble(parts[44]);
            Tsa104 = Convert.ToDouble(parts[45]);
            Tsa105 = Convert.ToDouble(parts[46]);
            Tsa106 = Convert.ToDouble(parts[47]);
            Ssa61 = Convert.ToDouble(parts[48]);
            Ssa64 = Convert.ToDouble(parts[49]);
            Ssa67 = Convert.ToDouble(parts[50]);
            Ssa70 = Convert.ToDouble(parts[51]);
            Ssa73 = Convert.ToDouble(parts[52]);
            Ssa76 = Convert.ToDouble(parts[53]);
            Gz117 = Convert.ToDouble(parts[54]);
            Gz118 = Convert.ToDouble(parts[55]);
            Gz122 = Convert.ToDouble(parts[56]);
            Ei202 = Convert.ToDouble(parts[57]);
            Tsa81 = Convert.ToDouble(parts[58]);
            Tsa82 = Convert.ToDouble(parts[59]);
            Tsa51 = Convert.ToDouble(parts[60]);
            Tsa52 = Convert.ToDouble(parts[61]);
            Tsa111 = Convert.ToDouble(parts[62]);
            Tsa112 = Convert.ToDouble(parts[63]);
            Tsa113 = Convert.ToDouble(parts[64]);
            Tsa114 = Convert.ToDouble(parts[65]);
            Tsa115 = Convert.ToDouble(parts[66]);
            Tsa116 = Convert.ToDouble(parts[67]);
            Ssa62 = Convert.ToDouble(parts[68]);
            Ssa65 = Convert.ToDouble(parts[69]);
            Ssa68 = Convert.ToDouble(parts[70]);
            Ssa71 = Convert.ToDouble(parts[71]);
            Ssa74 = Convert.ToDouble(parts[72]);
            Ssa77 = Convert.ToDouble(parts[73]);
            Gz119 = Convert.ToDouble(parts[74]);
            Gz120 = Convert.ToDouble(parts[75]);
            Gz123 = Convert.ToDouble(parts[76]);
            Ei203 = Convert.ToDouble(parts[77]);
            Tsa91 = Convert.ToDouble(parts[78]);
            Tsa92 = Convert.ToDouble(parts[79]);
            Tsa61 = Convert.ToDouble(parts[80]);
            Tsa62 = Convert.ToDouble(parts[81]);
            Tsa121 = Convert.ToDouble(parts[82]);
            Tsa122 = Convert.ToDouble(parts[83]);
            Tsa123 = Convert.ToDouble(parts[84]);
            Tsa124 = Convert.ToDouble(parts[85]);
            Tsa125 = Convert.ToDouble(parts[86]);
            Tsa126 = Convert.ToDouble(parts[87]);
            Ssa63 = Convert.ToDouble(parts[88]);
            Ssa66 = Convert.ToDouble(parts[89]);
            Ssa69 = Convert.ToDouble(parts[90]);
            Ssa72 = Convert.ToDouble(parts[91]);
            Ssa75 = Convert.ToDouble(parts[92]);
            Ssa78 = Convert.ToDouble(parts[93]);
        }

        public static void Kill()
        {

        }

        public static List<Cargo> ReadFile(string filename)
        {
            List<Cargo> res = new List<Cargo>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    Cargo p = new Cargo();

                    p.Piece(line);
                    res.Add(p);
                }
            }

            return res;
        }

    }

}

