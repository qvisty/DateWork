//https://studie.smartlearning.dk/mod/page/view.php?id=609338
//Lav et program som ved indtastning af et årstal kan fortælle
//1) hvilken dato det er mors dag?  (2. søndag i maj)
//2) på hvilken dato falder 1. søndag i advent?
//3) hvilken ugedag er 24. december?   
//4) på hvilken dato falder Thanksgiving?
//i USA er det 4. torsdag i november
//i Canada er det 2. mandag i oktober
//i Australien er det sidste onsdag i november

while (true)
{
    Console.Write("Indtast et årstal: ");
    int årstal = Convert.ToInt32(Console.ReadLine());

    //1) hvilken dato det er mors dag?  (2. søndag i maj)
    List<DateTime> søndageIMaj = new List<DateTime>();
    DateTime date = new DateTime(årstal, 5, 1);
    while (søndageIMaj.Count < 2)
    {
        // Finder navnet på ugedagen
        string dayofweek = Convert.ToString(date.DayOfWeek);
        if (dayofweek == "Sunday")

        {
            søndageIMaj.Add(date);
        }
        date = date.AddDays(1);
    }
    DateTime morsDag = søndageIMaj[1];

    Console.WriteLine("Mors dag - 2. søndag i maj - er: " + morsDag.ToString("dddd dd. MMMM yyyy"));

    //2) på hvilken dato falder 1. søndag i advent?
    List<DateTime> søndageFørAndenJuledag = new List<DateTime>();
    DateTime andenJuleDag = new DateTime(årstal, 12, 24);
    while (søndageFørAndenJuledag.Count < 4)
    {
        // Finder navnet på ugedagen
        string dayofweek = Convert.ToString(andenJuleDag.DayOfWeek);
        if (dayofweek == "Sunday")

        {
            søndageFørAndenJuledag.Add(andenJuleDag);
        }
        andenJuleDag = andenJuleDag.AddDays(-1);
    }
    DateTime førsteAdvent = søndageFørAndenJuledag[3];

    Console.WriteLine("1. søndag i advent er: " + førsteAdvent.ToString("dddd dd. MMMM yyyy"));

    //3) hvilken ugedag er 24. december?   
    DateTime juleaften = new DateTime(årstal, 12, 24);
    Console.WriteLine("Juleaften lander på en: " + juleaften.ToString("dddd"));

    //4) på hvilken dato falder Thanksgiving?
    //i USA er det 4. torsdag i november
    List<DateTime> torsdageINovember = new List<DateTime>();
    date = new DateTime(årstal, 11, 1);
    while (torsdageINovember.Count < 4)
    {
        // Finder navnet på ugedagen
        string dayofweek = Convert.ToString(date.DayOfWeek);
        if (dayofweek == "Thursday")

        {
            torsdageINovember.Add(date);
        }
        date = date.AddDays(1);
    }
    DateTime thanksgiving = torsdageINovember[3];

    Console.WriteLine("Thanksgiving i USA (4. torsdag i november) - er: " + thanksgiving.ToString("dddd dd. MMMM yyyy"));

    //i Canada er det 2. mandag i oktober
    List<DateTime> mandageIOktober = new List<DateTime>();
    date = new DateTime(årstal, 10, 1);
    while (mandageIOktober.Count < 2)
    {
        // Finder navnet på ugedagen
        string dayofweek = Convert.ToString(date.DayOfWeek);
        if (dayofweek == "Monday")

        {
            mandageIOktober.Add(date);
        }
        date = date.AddDays(1);
    }
    thanksgiving = mandageIOktober[1];

    Console.WriteLine("Thanksgiving i Canada (2. mandag i oktober) - er: " + thanksgiving.ToString("dddd dd. MMMM yyyy"));

    //i Australien er det sidste onsdag i november
    List<DateTime> onsdageiNovember = new List<DateTime>();

    for (int day = 1; day <= 30; day++)
    {
        date = new DateTime(årstal, 11, day);
        // Finder navnet på ugedagen
        string dayofweek = Convert.ToString(date.DayOfWeek);
        if (dayofweek == "Wednesday")

        {
            onsdageiNovember.Add(date);
        }
    }
    thanksgiving = onsdageiNovember.Last();

    Console.WriteLine("Thanksgiving i Australien (sidste onsdag i november) - er: " + thanksgiving.ToString("dddd dd. MMMM yyyy"));
    // Ny tom linje før vi starter igen
    Console.WriteLine();
}