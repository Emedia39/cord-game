
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //カードの数字入力用の配列
            string[] input = new string[4];
            //文字列inputの数値への変換を試行用
            int[] card = new int[4];



            Console.WriteLine("+------------------+");
            Console.WriteLine("|ポーカードゲーム！|");
            Console.WriteLine("+------------------+");

            for (int number = 0; number < 4; number++)
            {
                //対象メンバーの数を決める
                Console.WriteLine($"\n{number + 1}カード目の数を入力 ※ 1～4");

                input[number] = Console.ReadLine();

                //画面クリア
                Console.Clear();

                // 文字列inputの数値へ変換
                bool result01 = int.TryParse(input[number], out card[number]);

                if (card[number] < 1 || card[number] > 4)//1～4以外の時
                {
                    Console.WriteLine("想定外の値が入力されたため1に変換します");

                    card[number] = 1;//1にする
                }

            }

            Console.WriteLine("*----------------------------------*");
            for (int number = 0; number < 4; number++)
            {
                Console.WriteLine("{0}人目の番号は…{1}", number + 1, card[number]);

            }
            Console.Write("*----------------------------------*\n");

            //キー入力待ち
            Console.ReadLine();

            /*
            方法1.1～4の「card」をすべて「number」-「number」して0になったのが、一番多い数をペア数にする
            方法2.1～4の数を「number」に当てはめ、複数同じ数があったら、一番多い数をペア数にする←こっち
             */

            int[] serectCount = new int[4];//重複数カウント用配列
            for (int number = 0; number < 4; number++)
            {
                serectCount[number] = 0;//初期値
            }

            for (int number = 0; number < 4; number++)
            {
                if(card[number] == 1)
                {
                    serectCount[0]++;
                }
                if (card[number] == 2)
                {
                    serectCount[1]++;
                }
                if (card[number] == 3)
                {
                    serectCount[2]++;
                }
                if (card[number] == 4)
                {
                    serectCount[3]++;
                }

                /*if (card[number] == number+1)//失敗
                {
                    serectCount[number] += 1;
                }*/

            }

            Console.WriteLine(serectCount[0]);
            Console.WriteLine(serectCount[1]);
            Console.WriteLine(serectCount[2]);
            Console.WriteLine(serectCount[3]);

            //キー入力待ち
            Console.ReadLine();



        }
    }
}
