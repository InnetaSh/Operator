using Operator;

WeekSchedule weekschedule = new WeekSchedule();
weekschedule[0] = "Физика,\nфизкультура,\nрисование.";
try
{
    Console.WriteLine($"расписание на понедельник:\n {weekschedule[0]}\n");

    weekschedule["Понедельник"] = "Химия,\n биология,\n география.";
    Console.WriteLine($"расписание на понедельник:\n {weekschedule[0]}\n");
    //Console.WriteLine($"расписание на понедельник:\n {weekschedule["сботта"]}\n");
    Console.WriteLine($"расписание на понедельник:\n {weekschedule[-1]}\n");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error:" + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Error:" + ex.Message);
}