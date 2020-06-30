namespace CacheWork
{
    class Controller
    {
        public static MainMemory MainMemoryController;
        public static Cache CacheController;
        public bool FromCache;
        int StringsCount;

        public Controller(int segmentsCount, int stringsCount, int elementsCount)
        {
            StringsCount = stringsCount;
            MainMemoryController = new MainMemory(segmentsCount, stringsCount, elementsCount);
            CacheController = new Cache(stringsCount, elementsCount);
        }

        public int this[int i, int j, int k]
        {
            get
            {
                TagValidation(i, j);
                return CacheController[j, k];
            }
            set
            {
                TagValidation(i, j);
                CacheController[j, k] = value;
            }
        }

        // Проверяет совпадают ли требуемый и текущий теги строки
        void TagValidation(int i, int j)
        {
            FromCache = true;

            if (i != CacheController.GetTag(j))
            {
                FromCache = false;

                if (CacheController.GetTag(j) != -1)
                    MainMemoryController.SetString(CacheController.GetTag(j), j, CacheController[j]);

                CacheController[j] = MainMemoryController.GetString(i, j);
                CacheController.SetTag(j, i);
            }
        }
    }
}
