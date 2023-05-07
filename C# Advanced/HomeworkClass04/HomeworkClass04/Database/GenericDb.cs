using HomeworkClass04.Entities;

namespace HomeworkClass04.Database
{
    public static class GenericDb<T> where T : BaseEntity
    {
        public static List<T> Db;
        static GenericDb()
        {
            Db = new List<T>();
        }
        public static void InsertCar(T entity)
        {
            Db.Add(entity);
          
            Console.WriteLine($"The new car {entity.Brand} - {entity.Model} was aded to the {Db}");
           
        }
        public static void GetById(int id)
        {
            Console.WriteLine(Db.FirstOrDefault(x => x.Id == id));
            
        }
        public static void PrintAll()
        {
            foreach (T item in Db)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                item.GetInfo();
                Console.ResetColor();
            }
        }
    }
}
