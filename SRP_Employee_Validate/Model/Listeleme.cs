namespace SRP_Employee_Validate.Model
{
    internal class Listeleme
    {
        public static void ListeleEmployee()
        {
            foreach (Employee em in Data.employees)
            {
                Console.WriteLine($"ID:{em.ID} AD:{em.Firstname} SOYAD:{em.Lastname} Email:{em.Email}");
            }
        }
    }
}