using System;

namespace libray
{
    public class Animal
    {
        private String name;
        private double weight;
        private double weigth_now;

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
        /// 增加體重 並傳回增加後的體重
        /// </summary>
        /// <returns></returns>
        private double addWeight() {
            weigth_now += 0.1;
            return weigth_now;
        }

        /// <summary>
        /// 傳入食物名稱 並顯示食用後的體重
        /// </summary>
        /// <param name="food"></param>
        public void Eat( String food ) {
            Console.WriteLine( name + "正在吃" + food + ", 體重現在為" + addWeight() + "KG ");
        }

    }
}
