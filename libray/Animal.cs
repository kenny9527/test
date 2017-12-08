using System;

namespace libray
{
    public class Animal
    {
        //名字、原始體重(公克)、吃飽後體重(公克)
        private string _name;
        private double _weight;
        private double _weigthNow;

        /// <summary>
        /// 原始體重轉公斤
        /// </summary>
        public double weightKG
        {
            get
            {
                return _weight / 1000;
            }
        }
        /// <summary>
        /// 目前體重轉公斤
        /// </summary>
        public double weightNowKG
        {
            get
            {
                return _weigthNow / 1000;
            }
        }

        /// <summary>
        /// 顏色
        /// </summary>
        public string color { get; set; }


        public Animal(string name, double weight)
        {
            _name = name;
            _weight = weight;
            _weigthNow = weight;
        }

        /// <summary>
        /// 增加體重 100克
        /// </summary>
        /// <returns></returns>
        private void AddWeight() {
            _weigthNow += 100;
        }

        /// <summary>
        /// 傳入食物名稱 並顯示食用後的體重
        /// </summary>
        /// <param name="food"></param>
        public void Eat(string food ) {
            AddWeight();
            string str = string.Format("{0}正在吃{1}, 體重現在為{2}KG ", _name, food, weightNowKG);
            Console.WriteLine(str);
        }


        ///// <summary>
        ///// 取得目前體重的數字轉成公斤
        ///// </summary>
        ///// <returns></returns>
        //public double getweightnowkg()
        //{
        //    return weigthnow / 1000;
        //}

        ///// <summary>
        ///// 取得原始體重的數字轉成公斤
        ///// </summary>
        ///// <returns></returns>
        //public double getweightkg()
        //{
        //    return weight / 1000;
        //}

    }
}
