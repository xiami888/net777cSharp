using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    //值类型 int string 引用类型 List
    class Program
    {
        static void Main(string[] args)
        {
            DashBord db = new DashBord();
            db.Name = "速度仪表盘";
            db.Reset();
            db.Rotate(10.0);
            db.ShowValue();
            db.Save();

            Console.WriteLine();
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 仪表盘类
    /// </summary>
    class DashBord //仪表盘
    {
        //public string Name;//表盘名称
        public string Name { get; set; }
        private double value;//表盘读数
        public List<零件> 零s;
        /// <summary>
        /// 得到value值
        /// </summary>
        /// <returns>返回value</returns>
        public double GetValue() //得到value；
        {
            return this.value;
        }
        public void Rotate(double angle)//指针转动
        {
            value = angle;
            Console.WriteLine("指针转动了{0}度", angle);
        }
        public void Reset()//指针复位；
        {
            value = 0;
            Console.WriteLine("表盘复位完成！");
        }
        public void ShowValue()//显示当前读数
        {
            Console.WriteLine("当前表盘的读数为{0}", value);
        }
        public bool Save()//将表盘数据存储到数据库；
        {
            数据库 dataBase = new 数据库();
            dataBase.Store(this);
            return true;
        }
    }
    class 零件
    {
    }
    class 数据库
    {
        public bool Store(DashBord db)
        {
            db.GetValue();
            Console.WriteLine("值{0}存储数据库成功", db.GetValue());
            return true;
        }
    }
}
