using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    static class Day2
    {
        const string input = "1208_412_743_57_1097_53_71_1029_719_133_258_69_1104_373_367_365|4011_4316_1755_4992_228_240_3333_208_247_3319_4555_717_1483_4608_1387_3542|675_134_106_115_204_437_1035_1142_195_1115_569_140_1133_190_701_1016|4455_2184_5109_221_3794_246_5214_4572_3571_3395_2054_5050_216_878_237_3880|4185_5959_292_2293_118_5603_2167_5436_3079_167_243_256_5382_207_5258_4234|94_402_126_1293_801_1604_1481_1292_1428_1051_345_1510_1417_684_133_119|120_1921_115_3188_82_334_366_3467_103_863_3060_2123_3429_1974_557_3090|53_446_994_71_872_898_89_982_957_789_1040_100_133_82_84_791|2297_733_575_2896_1470_169_2925_1901_195_2757_1627_1216_148_3037_392_221|1343_483_67_1655_57_71_1562_447_58_1561_889_1741_1338_88_1363_560|2387_3991_3394_6300_2281_6976_234_204_6244_854_1564_210_195_7007_3773_3623|1523_77_1236_1277_112_171_70_1198_86_1664_1767_75_315_143_1450_1610|168_2683_1480_200_1666_1999_3418_2177_156_430_2959_3264_2989_136_110_3526|8702_6973_203_4401_8135_7752_1704_8890_182_9315_255_229_6539_647_6431_6178|2290_157_2759_3771_4112_2063_153_3538_3740_130_3474_1013_180_2164_170_189|525_1263_146_954_188_232_1019_918_268_172_1196_1091_1128_234_650_420";

        public static int Part1()
        {
            int sum = 0;
            string[][] inputMatrix = getInputMatrix();
            for (int rowIdx = 0; rowIdx < inputMatrix.Length; rowIdx++)
            {
                //sort row
                int maxLen = inputMatrix[rowIdx].Max(x => x.Length);
                inputMatrix[rowIdx] = inputMatrix[rowIdx].OrderBy(x => x.PadLeft(maxLen, '0')).ToArray();
                //get first and last number
                int firstNumber = Int32.Parse(inputMatrix[rowIdx][0]);
                int lastNumber = Int32.Parse(inputMatrix[rowIdx][inputMatrix[rowIdx].Length - 1]);

                sum += Math.Abs(firstNumber - lastNumber);
            }

            return sum;
        }



        private static string[][] getInputMatrix()
        {
            string[] lines = input.Split('|');
            return lines.Select(x => x.Split('_')).ToArray();
        }
    }
}
