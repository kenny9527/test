using System;

namespace libray
{
    public class Animal
    {
        //名字、原始體重(公克)、吃飽後體重(公克)
        private String name;
        private double weight{ get; set; }
        private double weigth_now{ get; set; }

        public Animal( String _name , double _weight) {
            name = _name;
            weight = _weight;
            weigth_now = _weight;
        }

        /// <summary>
        /// 顏色
        /// </summary>
        public String color{ get; set; }


        /// <summary>
        /// 增加體重 100克
        /// </summary>
        /// <returns></returns>
        private void addWeight() {
            weigth_now += 100;
        }

        /// <summary>
        /// 傳入食物名稱 並顯示食用後的體重
        /// </summary>
        /// <param name="food"></param>
        public void Eat( String food ) {
            addWeight();
            Console.WriteLine( name + "正在吃" + food + ", 體重現在為" + getWeight_now_KG() + "KG ");
        }


        /// <summary>
        /// 取得目前體重的數字轉成公斤
        /// </summary>
        /// <returns></returns>
        public double getWeight_now_KG()
        {
            return weigth_now / 1000;
        }

        /// <summary>
        /// 取得原始體重的數字轉成公斤
        /// </summary>
        /// <returns></returns>
        public double getWeight_KG() {
            return weight / 1000;
        }

    }
}
