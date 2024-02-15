using practice08task1;

Phone phone = new Phone(1, "Galaxy S21", "Samsung", 1500, "Android", 108);

Console.WriteLine($"Price with tax: { phone.CalcPriceWithTax()}");
phone.DisplayInfo();
phone.CheckCamera();