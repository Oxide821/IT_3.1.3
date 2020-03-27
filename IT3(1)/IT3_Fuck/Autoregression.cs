using System;

namespace IT3_Degradation
{
    class Autoregresion
    {
        int element = 12, noisePercent, amount, sizeM, size;
        double edge;
        Random rand;

        double[] ampArray, freqArray;

        public Autoregresion(double[] ampArray, double[] freqArray, int amount, int noisePercent, int sizeM, int size, double edge)
        {
            this.amount = amount;//количество синусоид
            this.sizeM = sizeM;
            this.noisePercent = noisePercent;
            this.size = size;// размер массива отсчётов предсказанного и исходного сигналов
            this.edge = edge;// порог

            this.ampArray = ampArray;// амплитуды
            this.freqArray = freqArray;// частоты


            rand = new Random();
        }

        public double[] CreateGraph(double[] signal)
        {
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < signal.Length; j++)
                {
                    signal[j] += Function(ampArray[i], freqArray[i], j);
                }
            }

            return signal;
        }
      //добавляем шум
        public double[] AddNoise(double[] signal)
        {
            double[] signalNoise = new double[signal.Length];
            double[] gaussElement = new double[element];

            for (int i = 0; i < signal.Length; i++)
            {
                signalNoise[i] = 0;
                for (int j = 0; j < element; j++)
                {
                    gaussElement[j] = GetRandom(-1, 1);
                    signalNoise[i] += gaussElement[j];
                }
                signalNoise[i] /= element;
            }

            double signal_en = 0, summ = 0;

            for (int i = 0; i < signalNoise.Length; i++)
            {
                signal_en += (signal[i] * signal[i]);
                summ += (signalNoise[i] * signalNoise[i]);
            }

            double noise_en = noisePercent * signal_en / 100; //энергия шума
            double alpha = Math.Sqrt(noise_en / summ);

            double[] record = new double[signal.Length];
            //прибавляем шум к основному сигналу
            for (int i = 0; i < record.Length; i++)
            {
                record[i] = signal[i];
                record[i] = record[i] + alpha * signalNoise[i];
            }

            return record;
        }

        public double[] Calc(double[] signal)
        {   //заполнение матрицы АКП
            double[] AKP = new double[sizeM];
            double[] conv = AKP_fill(signal);
            
            for(int i = 0; i < sizeM; i++)//получение первых элементов(число равно порядку с экрана)
            {
                AKP[i] = conv[i];
            }

            double[] buff = new double[sizeM];
            for (int i = 1; i < sizeM; i++)//копируем акп размера порядка в буферный массив
            {
                buff[i] = AKP[sizeM - i];
            }
            buff[0] = AKP[0];
            int NM = sizeM * sizeM;//размер матрицы акп размерности порядка
            double bufer_var;//последний элемент каждой строки
            int counter = 0, step = 0;

            double[] ARM = new double[sizeM * sizeM];//Rxx

            while (counter < NM)
            {
                for (int i = 0; i < sizeM; i++)//заполнение одной строки ARM
                {
                    ARM[step] = buff[i];
                    step++;
                }
                bufer_var = buff[sizeM - 1];//последний элеменнт текущей строки
                for (int j = sizeM - 1; j > 0; j--)//смещение элементов вправо на единицу
                {
                    buff[j] = buff[j - 1];
                }
                buff[0] = bufer_var;//последний элемент на первое место
                counter += sizeM;
            }

           
            double porog = edge;//порог нужен для численного значения Ро в столбце свободных членов
            porog /= 100;
            int order_YW = 2 * amount + 1;//порядок м. Ю.-У.(2*N+1)

            double[] neizv = new double[order_YW];//(столбец коэффициентов а)
            double[] Stolb = new double[order_YW];//столбец свободных членов

            //for (int i = 0; i < stop; i++)
            //{
            //    neizv[i] = 0;
            //    Stolb[i] = 0;
            //}
            neizv[0] = 1;
            Stolb[0] = porog * ARM[0];//вычисление Ро

            double[] kazMatrix = new double[order_YW * order_YW];//заполнение матрицы Ю-У.
            int st = 0, count = 0;
            for (int j = 0; j < order_YW; j++)
            {
                for (int i = 0; i < order_YW; i++)
                {
                    kazMatrix[i + count] = ARM[i + st];
                }
                st += sizeM;
                count += order_YW;
            }

            kazf(kazMatrix, Stolb, ref neizv, order_YW, order_YW);//призыв паладина Качмаржа

            double[] auto_reg = new double[signal.Length];//массив отсчетов предсказаного сигнала

            for (int i = 0; i < order_YW; i++)//получение отсчётов для предсказания
            {
                auto_reg[i] = signal[i];
            }

           
            
            for (int j = 1; j < order_YW; j++)//получение предсказаных отсчётов Xn(формула из блокнота, писал Морозов)
            {
                for (int i = order_YW; i < signal.Length; i++)
                {
                    auto_reg[i] -= neizv[j] * auto_reg[i - j];//auto_reg[i] -= neizv[j] * signal[i - j]; - говно, работает не правильно.
                }
            }

            return auto_reg;
        }

        private double GetRandom(double minimum, double maximum)// для шума
        {
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        private double Function(double amp, double freq, int current)//синусоида
        {
            return amp * Math.Sin(2 * Math.PI * freq * current);
        }

        
        private double[] AKP_fill(double[] S)
        {
            double[] Convol = new double[S.Length];
            for (int i = 0; i < size; i++)
            {
                ///Convol[i] = 0;
                for (int j = 0; j < size; j++)// счетчик предыдущих отсчетов сигнала
                {
                    if ((i - j) < 0)
                        Convol[i] += S[j] * S[size + (i - j)];//свёртка(получение текущей автокорелляции, вместо второй S- может быть любая функция в зависимости от условий)
                    else
                        Convol[i] += S[j] * S[i - j];
                }
            }
            return Convol;//итоговый массив автокореляций
        }


        //метод Качмаржа
        void kazf(double[] a, double[] b, ref double[] x, int nn, int ny)
        /* матрица А, столбец свободных членов, массив неизвестных,
        nn - количество неизвестных;  ny - количество уравнений*/
        {

            //double eps = 1.e - 6f;
            double eps = 1e-6;
            //float s;
            int i, j, k;
            double s1, s2, fa1, t;
            double[] x1;

            x1 = new double[nn];

            x[0] = 0.5f;
            for (i = 1; i < nn; i++) x[i] = 0F;

            s1 = s2 = 1F;
            while (s1 > eps * s2)
            {
                for (i = 0; i < nn; i++) x1[i] = x[i];

                for (i = 0; i < ny; i++)
                {
                    s1 = 0.0;
                    s2 = 0.0;
                    for (j = 0; j < nn; j++)
                    {
                        fa1 = a[i * nn + j];
                        s1 += fa1 * x[j];
                        s2 += fa1 * fa1;
                    }
                    t = (b[i] - s1) / s2;
                    for (k = 0; k < nn; k++) x[k] += a[i * nn + k] * t;
                }

                x[0] = 1.0; //первый элемент массива неизвестных всегда равен единице
                s1 = 0.0;
                s2 = 0.0;
                for (i = 0; i < nn; i++)
                {
                    s1 += (x[i] - x1[i]) * (x[i] - x1[i]);
                    s2 += x[i] * x[i];
                }
                s1 = Math.Sqrt(s1);
                s2 = Math.Sqrt(s2);
            }
        }
    }
}
