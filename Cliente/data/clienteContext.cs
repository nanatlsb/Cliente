namespace Cliente.data

{
    public class clienteContext : DbContext
    {
        public clienteContext(DbContextOptions<clienteContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }

}
