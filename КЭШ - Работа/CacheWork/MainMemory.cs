using System;
using System.IO;

namespace CacheWork
{
    class MainMemory
    {
        BinaryWriter BinaryWrite;
        BinaryReader BinaryRead;

        int SegmentsCount,
            StringsCount,
            ElementsCount;

        public MainMemory(int segmentsCount, int stringsCount, int elementsCount)
        {
            Random values = new Random();
            SegmentsCount = segmentsCount;
            StringsCount = stringsCount;
            ElementsCount = elementsCount;

            using (BinaryWrite = new BinaryWriter(new FileStream("Memory.ini", FileMode.Create)))
            {
                for (int i = 0; i < SegmentsCount; i++)
                {
                    BinaryWrite.Write((char)10);

                    for (int j = 0; j < StringsCount; j++)
                    {
                        for (int k = 0; k < ElementsCount; k++)
                        {
                            BinaryWrite.Write(values.Next(1000, 9999));
                            BinaryWrite.Write(' ');
                        }
                        BinaryWrite.Write((char)10);
                    }
                }
            }
        }

        void Positioning(int segment, int str, IDisposable WriteRead)
        {
            segment--;
            str--;

            int position = (segment + 1) + // Отступы между блоками
                (segment * (StringsCount * ((ElementsCount * 4) + 5))) +  // Пропуск эл-та до нужного сегмента
                (str * ((ElementsCount * 4) + 5)); // Пропуск эл-та до нужной строки 

            // Позиция каретки с учетом размеров
            switch (WriteRead)
            {
                case BinaryWriter writer:
                    writer.BaseStream.Position = position;
                    break;
                case BinaryReader reader:
                    reader.BaseStream.Position = position;
                    break;
            }
        }

        // Получить строку в сегменте
        public int[] GetString(int segment, int str)
        {
            int[] temp = new int[ElementsCount];

            using (BinaryRead = new BinaryReader(new FileStream("Memory.ini", FileMode.Open)))
            {
                Positioning(segment, str, BinaryRead);

                for (int i = 0; i < ElementsCount; i++)
                {
                    temp[i] = BinaryRead.ReadInt32();
                    BinaryRead.BaseStream.Position++;
                }
            }

            return temp;
        }

        // Записать строку temp в строку str в сегменте segment
        public void SetString(int segment, int str, int[] temp)
        {
            using (BinaryWrite = new BinaryWriter(new FileStream("Memory.ini", FileMode.Open)))
            {
                Positioning(segment, str, BinaryWrite);

                for (int i = 0; i < ElementsCount; i++)
                {
                    BinaryWrite.Write(temp[i]);
                    BinaryWrite.Write(' ');
                }
            }
        }
    }
}
