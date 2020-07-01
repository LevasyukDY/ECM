namespace CacheWork
{
    class Cache
    {
        (int Tag, int[] Line)[] Page;

        public Cache(int stringsCount, int elementsCount)
        {
            Page = new (int Tag, int[] Line)[stringsCount];
            for (int i = 0; i < Page.Length; i++)
            {
                Page[i].Line = new int[elementsCount];
                Page[i].Tag = -1;
            }
        }

        // Получить или изменить элемент
        public int this[int i, int j]
        {
            get => Page[i - 1].Line[j - 1];
            set => Page[i - 1].Line[j - 1] = value;
        }

        // Получить или изменить строку
        public int[] this[int i]
        {
            get => Page[i - 1].Line;
            set => Page[i - 1].Line = value;
        }

        // Получить или изменить тэг
        public int GetTag(int i) => Page[i - 1].Tag;
        public void SetTag(int i, int newTag) => Page[i - 1].Tag = newTag;
    }
}
