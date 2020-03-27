using System;


namespace IT3_Degradation
{
    struct Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
    }

    class Autoregression
    {
        int element = 15, noisePercent, amount, sizeM, size;
        double edge;
        Random rand;

        double[] ampArray, freqArray;
        Complex[] source, predicted;
        public double[] sourceModule, predictedModule;

        public Autoregression(double[] ampArray, double[] freqArray, int amount, int noisePercent, int sizeM, int size, double edge)
        {
            this.amount = amount;
            this.sizeM = sizeM;
            this.noisePercent = noisePercent;
            this.size = size;
            this.edge = edge;

            this.ampArray = ampArray;
            this.freqArray = freqArray;


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
        {
            double[] AKP = new double[sizeM];
            double[] conv = AKP_fill(signal);
            
            for(int i = 0; i < sizeM; i++)
            {
                AKP[i] = conv[i];
            }

            double[] buff = new double[sizeM];
            for (int i = 1; i < sizeM; i++)
            {
                buff[i] = AKP[sizeM - i];
            }
            buff[0] = AKP[0];
            int NM = sizeM * sizeM;
            double bufer_var;
            int counter = 0, step = 0;

            double[] ARM = new double[sizeM * sizeM];

            while (counter < NM)
            {
                for (int i = 0; i < sizeM; i++)
                {
                    ARM[step] = buff[i];
                    step++;
                }
                bufer_var = buff[sizeM - 1];
                for (int j = sizeM - 1; j > 0; j--)
                {
                    buff[j] = buff[j - 1];
                }
                buff[0] = bufer_var;
                counter += sizeM;
            }

           
            double porog = edge;
            porog /= 100;
            int stop = 2 * amount + 1;

            double[] neizv = new double[stop];
            double[] Stolb = new double[stop];

            for (int i = 0; i < stop; i++)
            {
                neizv[i] = 0;
                Stolb[i] = 0;
            }
            neizv[0] = 1;
            Stolb[0] = porog * ARM[0];

            double[] kazMatrix = new double[stop * stop];
            int st = 0, count = 0;
            for (int j = 0; j < stop; j++)
            {
                for (int i = 0; i < stop; i++)
                {
                    kazMatrix[i + count] = ARM[i + st];
                }
                st += sizeM;
                count += stop;
            }

            kazf(kazMatrix, Stolb, ref neizv, stop, stop);

            double[] auto_reg = new double[signal.Length];

            for (int i = 0; i < stop; i++)
            {
                auto_reg[i] = signal[i];
            }

           
            
            for (int j = 1; j < stop; j++)
            {
                for (int i = stop; i < signal.Length; i++)
                {
                    auto_reg[i] -= neizv[j] * auto_reg[i - j];// auto_reg[i] -= neizv[j] * signal[i-j];
                }
            }



            source = new Complex[signal.Length];
            predicted = new Complex[auto_reg.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].Re = signal[i];
                source[i].Im = 0;
            }

            for (int i = 0; i < predicted.Length; i++)
            {
                predicted[i].Re = auto_reg[i];
                predicted[i].Im = 0;
            }

            Fourea(ref source, source.Length, -1);
            Fourea(ref predicted, predicted.Length, -1);

            sourceModule = new double[source.Length];
            predictedModule = new double[predicted.Length];

            for (int i = 0; i < source.Length; i++)
            {
                sourceModule[i] = Math.Pow(source[i].Re, 2) + Math.Pow(source[i].Im, 2);
            }

            for (int i = 0; i < predicted.Length; i++)
            {
                predictedModule[i] = Math.Pow(predicted[i].Re, 2) + Math.Pow(predicted[i].Im, 2);
            }



            return auto_reg;
        }

        private double GetRandom(double minimum, double maximum)
        {
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        private double Function(double amp, double freq, int current)
        {
            return amp * Math.Sin(2 * Math.PI * freq * current);
        }

        private double[] AKP_fill(double[] S)
        {
            double[] Convol = new double[S.Length];
            for (int i = 0; i < size; i++)
            {
                Convol[i] = 0;
                for (int j = 0; j < size; j++)
                {
                    if ((i - j) < 0)
                        Convol[i] += S[j] * S[size + (i - j)];
                    else
                        Convol[i] += S[j] * S[i - j];
                }
            }
            return Convol;
        }

        void Fourea(ref Complex[] spectr, int n, int direct)
        {
            int i, j, istep;
            int m, mmax;
            double r, r1, theta, w_r, w_i, temp_r, temp_i;
            double pi = 3.1415926f;

            r = pi * direct;
            j = 0;
            for (i = 0; i < n; i++)
            {
                if (i < j)
                {
                    temp_r = spectr[j].Re;
                    temp_i = spectr[j].Im;
                    spectr[j].Re = spectr[i].Re;
                    spectr[j].Im = spectr[i].Im;
                    spectr[i].Re = temp_r;
                    spectr[i].Im = temp_i;
                }
                m = n >> 1;
                while (j >= m) { j -= m; m = (m + 1) / 2; }
                j += m;
            }

            mmax = 1;
            while (mmax < n)
            {
                istep = mmax << 1;
                r1 = r / (float)mmax;
                for (m = 0; m < mmax; m++)
                {
                    theta = r1 * m;
                    w_r = (float)Math.Cos((double)theta);
                    w_i = (float)Math.Sin((double)theta);
                    for (i = m; i < n; i += istep)
                    {
                        j = i + mmax;
                        temp_r = w_r * spectr[j].Re - w_i * spectr[j].Im;
                        temp_i = w_r * spectr[j].Im + w_i * spectr[j].Re;
                        spectr[j].Re = spectr[i].Re - temp_r;
                        spectr[j].Im = spectr[i].Im - temp_i;
                        spectr[i].Re += temp_r;
                        spectr[i].Im += temp_i;
                    }
                }
                mmax = istep;
            }

            if (direct > 0)
            {
                for (i = 0; i < n; i++)
                {
                    spectr[i].Re /= (float)n;
                    spectr[i].Im /= (float)n;
                }
            }
        }

        //метод Качмаржа
        void kazf(double[] a, double[] b, ref double[] x, int nn, int ny)
        /* матрица А, столбец свободных членов, массив неизвестных,
        nn - количество неизвестных;  ny - количество уравнений*/
        {
            double eps = 1e-6;
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
