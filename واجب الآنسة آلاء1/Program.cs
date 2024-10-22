using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace واجب_الآنسة_آلاء1
{
    // بعرف أنو ما بصير حط تةابع إدخال وطباعى بقلب ال\الة من شان تصير قابلى لإعادة الاستخدام بس لأن بنص السؤال هيم فهمت.
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] ints = new int[] { 35, 35, 35, 40 };
            for (int i = 0; i < ints.Length; i++)
                Console.Write(ints[i] + "\t");
            Console.WriteLine();
            int[] r = null;
            ints = BackingRepitingValuesInList(ints, r, 0);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine((i + 25) + "\t" + ints[i]);
            }
        }
        /// <summary>
        /// هي دالة حساب كل قيمة كم مرى تكررت بالمصفوفة عا بس بالطريقة العودية
        /// </summary>
        /// <param name="list">المصفوفة يلي عم نشةف كل عنصر من عناصرها كم مرة تكرر</param>
        /// <param name="repet">المصفوفة يلي فيها مرات التكرار</param>
        /// <param name="index">المكنان يلي صرنا فيه بالمصففة يلي عم نشوف القيم تبعها</param>
        /// <returns>المصفوفه يلي فيها مرات التكارا</returns>
        static int[] BackingRepitingValuesInList(int[] list, int[] repet, int index)
        {
            if (repet == null) repet = new int[75 - 25 + 1];
            if (index < list.Length)
            {
                repet[list[index] - 25]++;
                return BackingRepitingValuesInList(list, repet, index + 1);
            }
            return repet;
        }
        /// <summary>
        /// حساب كل قيمة كم مرى تكررت بالطريقة العادية
        /// </summary>
        /// <param name="list">المصفوفة يلي بدنا نعد المختويات يي فيهاكم مرة تكررو</param>
        /// <returns>المصفوفة يلي فيها كل القيم من 25 لـ 75 يلي بدنا نعدن</returns>
        static int[] RepitingValuesInList(int[] list)
        {
            int[] repet = new int[75 - 25 + 1];
            for (int i = 0; i < list.Length; i++)
                repet[list[i] - 25]++;
            return repet;
        }
        /// <summary>
        /// هي دالة إدخال القيم للمصفوفة من قبل المستخدم
        /// </summary>
        /// <param name="Length">طول المصفوفة</param>
        /// <returns>المصفوفة بعد تعبايتها</returns>
        static int[] EnterListByUser(int Length)
        {
            int[] List = new int[Length];
            for (int i = 0; i < Length; i++)
                do
                {
                    Console.WriteLine("Enter a number between 25 and 75 to add it in index:{0} in the list:", i);
                    List[i] = int.Parse(Console.ReadLine());
                } while (List[i] < 25 || List[i] > 75);
            return List;
        }
        /// <summary>
        /// ملئ المصفوفة بشكل عشوائي وتلقائي
        /// </summary>
        /// <param name="Length"></param>
        /// <returns></returns>
        static int[] EnterListRandomly(int Length)
        {
            int[] List = new int[Length];
            for (int i = 0; i < Length; i++)
                List[i] = rand.Next(25, 75);
            return List;
        }
    }
}