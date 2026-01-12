namespace Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataInMemoryContext context = new DataInMemoryContext();

            do
            {

                Console.WriteLine("1.  Add Category");
                Console.WriteLine("2.  Update Category");
                Console.WriteLine("3.  Delete Category");
                Console.WriteLine("4.  Add Book");
                Console.WriteLine("5.  Update Book");
                Console.WriteLine("6.  Delete Book");
                Console.WriteLine("7.  Search Book");
                Console.WriteLine("8.  Add User");
                Console.WriteLine("9.  Update User");
                Console.WriteLine("10. Delete User");
                Console.WriteLine("11. Borrow/Return Book");
                Console.WriteLine("12. Exist");

                Console.WriteLine("Enter Your selection: ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        {

                            Console.WriteLine("Enter Id");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter Description");
                            string description = Console.ReadLine();

                            context.Categories.Add(new()
                            {
                                Id = id,
                                Name = name,
                                Description = description
                            });

                            Console.WriteLine("Add Category Successfully");

                        }
                        break;

                    case "2":
                        {

                            Console.WriteLine("Enter Category Name");
                            string name = Console.ReadLine();

                            bool isFounded = false;
                            foreach (var item in context.Categories)
                            {
                                if (item.Name == name)
                                {

                                    Console.WriteLine("Enter Id");
                                    int id = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Name");
                                    string newName = Console.ReadLine();

                                    Console.WriteLine("Enter Description");
                                    string description = Console.ReadLine();

                                    item.Id = id;
                                    item.Name = newName;
                                    item.Description = description;

                                    Console.WriteLine("Update Category Successfully");

                                    isFounded = true;
                                    break;
                                }
                            }

                            if (!isFounded)
                                Console.WriteLine("Category Not Founded");
                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine("Enter Category Name");
                            string name = Console.ReadLine();

                            bool isFounded = false;
                            foreach (var item in context.Categories)
                            {
                                if(item.Name == name)
                                {
                                    context.Categories.Remove(item);
                                    Console.WriteLine("Remove Category Successfully");

                                    isFounded = true;
                                    break;
                                }
                            }

                            if(!isFounded)
                                Console.WriteLine("Category Not Founded");
                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine("Enter ISBN:");
                            string isbn = Console.ReadLine();

                            Console.WriteLine("Enter Title:");
                            string title = Console.ReadLine();

                            Console.WriteLine("Enter Description:");
                            string description = Console.ReadLine();

                            Console.WriteLine("Enter Author:");
                            string author = Console.ReadLine();

                            Console.WriteLine("Enter Price:");
                            long price = Convert.ToInt64(Console.ReadLine());

                            Console.WriteLine("Enter Quantity:");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Category Name:");
                            string categoryName = Console.ReadLine();


                            bool categoryIsFounded = false;
                            foreach (var item in context.Categories)
                            {
                                if(item.Name == categoryName)
                                {

                                    context.Books.Add(new()
                                    {
                                        ISBN = isbn,
                                        Author = author,
                                        Title = title,
                                        Description = description,
                                        Price = price,
                                        CategoryName = categoryName,
                                        Quantity = quantity
                                    });

                                    Console.WriteLine("Add Book Successfully");

                                    categoryIsFounded = true;
                                    break;
                                }
                            }

                            if(!categoryIsFounded)
                                Console.WriteLine("Category Not Founded");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                        }
                        break;
                }

            } while(true); 
        }
    }
}
