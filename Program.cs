/* Desenvolver um sistema para controlar eventos públicos durante a pandemia. As pessoas se registrarão neste 
sistema com nome, endereço e idade. E os eventos que serão criados podem ter várias pessoas, mas não mais que 20. 
Os eventos serão cadastrados com nome, local e valor. Será perguntado no momento do cadastro se o evento vai ser pago,caso não seja
,o valor vai ser automaticamente atribuído a 0,
 caso tenha, vai ser solicitado este valor. */


using Atividade_Evento;

//==========================Pessoa==========================

Pessoa p1 = new Pessoa("Leonardo", 17, "Rua dois de Julho");
Pessoa p2 = new Pessoa("Ryan", 19, "Rua do Curio");

Console.WriteLine($"\nNome:{p1.Nome}\nIdade:{p1.Idade}");
Console.WriteLine($"\nNome:{p2.Nome}\nIdade:{p2.Idade}");

p1.AdicionarPessoa("Leonardo");

//===========================================================

//==========================Evento==========================

Console.WriteLine();
Console.WriteLine();

//==========================================================