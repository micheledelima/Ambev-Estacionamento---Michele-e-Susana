

using Modulo1.Console.Entidades;

//Usuario usuario = new Usuario();
//usuario.NovoUsuario("123", "tg", "Thamirys", TipoUsuario.Admin);

Usuario usuarioEstatico = Usuario.NovoUsuario("123", "tg", "Thamirys", TipoUsuario.Admin);

usuarioEstatico.InativarUsuario();

Console.ReadLine();