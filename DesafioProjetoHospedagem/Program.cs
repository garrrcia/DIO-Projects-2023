using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;


Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de cadastro de hóspedes e adiciona na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa hospede1 = new Pessoa(nome: "Samir");
Pessoa hospede2 = new Pessoa(nome: "Pedro");
Pessoa hospede3 = new Pessoa(nome: "Marina");
Pessoa hospede4 = new Pessoa(nome: "Phelipe");
Pessoa hospede5 = new Pessoa(nome: "Kenya"); 

hospedes.Add(hospede1);
hospedes.Add(hospede2);
hospedes.Add(hospede3);
hospedes.Add(hospede4);
hospedes.Add(hospede5);

Console.WriteLine();

 List<Suite> suites = new List<Suite>(); 
       
//Cria a suite
Suite suiteApartamentoJardim = new Suite(nomeSuite: "Apartamento Jardim", capacidade: 3, comodidadesSuite: "TV por assinatura, cofre eletrônico, rádio-relógio, frigobar, máquina de café expresso, telefone, secador de cabelo, ducha quente e fria, ar condicionado e porta-malas",
descricaoSuite: "Apartamentos com área de 45m² e uma ampla varanda de vista lateral do empreendimento",
valorDiaria: (decimal)2486,00);

Suite suiteApartamentoVistaMar = new Suite(nomeSuite: "Apartamento Jardim", capacidade: 4, comodidadesSuite: "TV por assinatura, cofre eletrônico, rádio-relógio, frigobar, máquina de café expresso, telefone, ducha quente e fria, secador de cabelo, ar condicionado e porta-malas.",
descricaoSuite: "Unidades com duas amplas varandas (lateral e frontal) de onde se pode apreciar uma incrível vista do mar de Muro Alto. ",
valorDiaria: (decimal)3.853,00);

Suite suiteBangaloJardim = new Suite(nomeSuite: "Apartamento Jardim", capacidade: 5, comodidadesSuite: "TV por assinatura, cofre eletrônico, rádio-relógio, frigobar, máquina de café expresso, telefone, ducha quente e fria, secador de cabelo, ar condicionado e porta-malas.",
descricaoSuite: "Bangalôs independentes, desenhados para oferecer conforto, tranqüilidade e privacidade. Com área de 64m2 distribuídos entre lâminas d'água e jardins, possuem varanda espaçosa e piscina privativa de profundidade variada. Um ambiente de estar aconchegante composto de sofá e conjunto de mesa e cadeiras mescla-se com o quarto do casal.",
valorDiaria: (decimal)3.853,00);

suites.Add(suiteApartamentoJardim);
suites.Add(suiteApartamentoVistaMar);
suites.Add(suiteBangaloJardim);
// Cria Reserva
Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suites);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
