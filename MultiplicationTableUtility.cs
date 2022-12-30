using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MltplTableUtility
{
    public class MultiplicationTableUtility
    {
        private static string Result = String.Empty;

        private int _multiplicandRange; // 被乘數的範圍
        private int _multiplierRange;   // 乘數的範圍

        public int MultiplicandRange
        {
            get { return _multiplicandRange; }

            set // 在set寫驗證, 預設值
            {
                if (value >= 1 && value <= 9)
                {
                    _multiplicandRange = value;
                }
                else
                {
                    _multiplicandRange = 9;
                }
            }
        }
        public int MultiplierRange
        {
            get { return _multiplierRange; }

            set // 在set寫驗證, 預設值
            {
                if (value >= 1 && value <= 9)
                {
                    _multiplierRange = value;
                }
                else
                {
                    _multiplierRange = 9;
                }
            }
        }


        public virtual string CreateTable()
        {
            Result = String.Empty;
            
            for (int i = 2; i <= MultiplicandRange; i++)
            {
                CreateParts(i, MultiplierRange);
                Result += "\n";
            }
            
            return Result;
        }


        /// <summary>
        /// 針對單一被乘數製作乘法表
        /// </summary>
        /// <param name="Mltplcand">單一被乘數</param>
        /// <param name="MltplierRange">乘數範圍</param>
        private static void CreateParts(int Mltplcand, int MltplierRange)
        {
            for (int i = 1; i <= MltplierRange; i++)
            {
                string quotient = (Mltplcand * i).ToString();

                Result += Mltplcand.ToString()
                       +  $" * {i} = "
                       +  quotient.PadLeft(2) + "\n";
            }
        }
    }
}
