using System;

namespace _46算法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 10, 3, 15, 11, 20 };
            int[] outarrayformaopao, outarrayforSelectionSart,outarrayforInsertSart,outarrayforShellSort;

            #region 冒泡排序
            MaoPao(array, out outarrayformaopao);
            foreach (var item in outarrayformaopao)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine("");
            #endregion


            #region 选择排序
            SelectionSart(array, out outarrayforSelectionSart);
            foreach (var item in outarrayforSelectionSart)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine("");
            #endregion

            #region 插入排序
            InsertionSort(array, out outarrayforInsertSart);
            foreach (var item in outarrayforInsertSart)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine("");
            #endregion

            #region 希尔排序
            ShellSort(array, out outarrayforShellSort);
            foreach (var item in outarrayforShellSort)
            {
                Console.Write(item + " - ");
            } 
            #endregion

            Console.ReadKey();
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="array">待传入的数组</param>
        /// <param name="outarray">输出比较后的数组</param>
        public static void MaoPao(int[] array,out int[] outarray)
        {
           
            int temp;
            for (int i = 0; i < array.Length-1; i++)
            {
                bool falg = true;
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        falg = false;
                    }
                }
                if (falg)
                {
                    break;
                }
            }
            outarray = array;
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="array">带传入的数组</param>
        /// <param name="outarray">输出比较后的数组</param>
        public static void SelectionSart(int[] array, out int[] outarray)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index = i;//存储变量i 的值，这是为了避免重复的比较，因为在每一轮的比较结束后，前i个元素的值已经排好序了，无需再次比较
                for (int j = 1 + i; j < array.Length; j++)
                {
                    if (array[j] < array[index])
                    {
                        index = j;//保存最小元素下标
                    }
                }
                // 此时已经找到最小元素的下标
                // 将最小元素与前面的元素交换
                int temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
            outarray = array;

        }

        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="array">带出入的数组</param>
        /// <param name="outarray">输出比较后的数组</param>
        public static void InsertionSort(int[] array, out int[] outarray)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //定义待插入的数组
                int insertValue = array[i];
                //找到待查入数组的前一个数的下标
                int insertIndex = i - 1;
                while (insertIndex >= 0 && insertValue < array[insertIndex])
                {
                    array[insertIndex + 1] = array[insertIndex];
                    insertIndex--;
                }
                array[insertIndex + 1] = insertValue;

            }
            outarray = array;
        }

        /// <summary>
        /// 希尔排序
        /// </summary>
        /// <param name="array">待传入的数组</param>
        /// <param name="outarray">输出比较后的数组</param>
        public static void ShellSort(int[] array, out int[] outarray)
        {
            for (int gap = array.Length/2; gap > 0; gap/=2)
            {
                //对数组元素进行分组
                for (int i = gap; i < array.Length; i++)
                {
                    //遍历各组的元素
                    for (int j = i-gap; j >= 0; j-=gap)
                    {
                        //交换元素
                        if (array[j] > array[j + gap])
                        {
                            int temp = array[j];
                            array[j] = array[j + gap];
                            array[j + gap] = temp;
                        }
                    }
                }
            }
            outarray = array;
        }
    }
}
