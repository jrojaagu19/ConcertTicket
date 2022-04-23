using ConcertTicket.Data.Entities;

namespace ConcertTicket.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntranceAsync();
            await CheckTicketAsync();
            

        }

        private async Task CheckEntranceAsync()
        {

           
            string Nb = " ";
            if (!_context.Entrances.Any())
            {
                for (int i = 1; i <= 5000; i++)
                {

                    Random rnd = new Random();
                    int Cont = rnd.Next(1, 4);

                    if (Cont == 1)
                        {
                            Nb = "Norte";

                        }
                        else
                            if (Cont == 2)
                        {
                            Nb = "Sur";

                        }
                        else
                            if (Cont == 3)
                        {
                            Nb = "Oriente";

                        }
                        else
                        if (Cont == 4)
                        {
                            Nb = "Occidente";
                            
                        }

                        
                        _context.Entrances.Add(new Entrance { Description = Nb }); ;
                    
                }
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTicketAsync()
        {
            int Cont = 1;

            if (!_context.Tickets.Any())
            {



                for (int i = 1; i <= 5000; i++)
                {
                    _context.Tickets.Add(new Ticket
                    {
                        Id = i,
                        WasUsed = false,
                        Document = " ",
                        Name = " ",
                        Entrance = null,
                    });
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
