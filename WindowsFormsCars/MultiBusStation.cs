using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс многоуровневой стоянки автобусов.
    /// </summary>
    class MultiBusStation
    {
        /// <summary>
        /// Список с уровнями парковки.
        /// </summary>
        List<BusStation<ITransport>> busStationsStages;

        /// <summary>
        /// Сколько мест на каждом уровне.
        /// </summary>
        private const int countPlaces = 20;

        /// <summary>
        /// Ширина окна отрисовки.
        /// </summary>
        private int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки.
        /// </summary>
        private int pictureHeight;

        public MultiBusStation(int countStages, int pictureWidth, int pictureHeight)
        {
            busStationsStages = new List<BusStation<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; i++)
            {
                busStationsStages.Add(new BusStation<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public BusStation<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < busStationsStages.Count)
                {
                    return busStationsStages[ind];
                }
                return null;
            }
        }

        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    // Записываем количество уровней.
                    WriteToFile("CountLeveles:" + busStationsStages.Count + Environment.NewLine, fs);
                    foreach(var level in busStationsStages)
                    {
                        // Начинаем уровень.
                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            foreach (var bus in level)
                            {
                                if (bus.GetType().Name == "Bus")
                                {
                                    WriteToFile(":Bus:", fs);
                                }
                                if (bus.GetType().Name == "DoubleBus")
                                {
                                    WriteToFile(":DoubleBus:", fs);
                                }
                                WriteToFile(bus + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод записи информации в файл.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="stream"></param>
        public void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        /// <summary>
        /// Загрузка инфомации по автомобилям на парковках из файла.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }

            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                // Считываем количество уровней.
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (busStationsStages != null)
                {
                    busStationsStages.Clear();
                }
                busStationsStages = new List<BusStation<ITransport>>(count);
            } else
            {
                // Если такой записи нет, то это не те данные.
                throw new Exception("Неверный формат файла");
            }

            int counter = -1;
            int counterBus = 0;
            ITransport bus = null;
            for (int i = 1; i < strs.Length; i++)
            {
                // Идем по считанным записям.
                if (strs[i] == "Level")
                {
                    // Начинаем новый уровень.
                    counter++;
                    counterBus = 0;
                    busStationsStages.Add(new BusStation<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }

                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }

                if (strs[i].Split(':')[1] == "Bus")
                {
                    bus = new Bus(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "DoubleBus")
                {
                    bus = new DoubleBus(strs[i].Split(':')[2]);
                }

                busStationsStages[counter][counterBus++] = bus;
            }
        }

        public void Sort()
        {
            busStationsStages.Sort();
        }
    }
}
