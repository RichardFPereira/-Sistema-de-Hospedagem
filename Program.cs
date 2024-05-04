﻿using System.Text;
using _Sistema_de_Hospedagem.Models;
using _Sistema_de_Hospedagem.Enum;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(Nome: "José", Sobrenome:"da Silva");
Pessoa p2 = new Pessoa(Nome: "Maria", Sobrenome:"do Socorro");

hospedes.Add(p1);

Suite suite = new Suite(TipoSuiteEnum.PREMIUM, Capacidade: 2, ValorDiaria: 30);

Reserva reserva = new Reserva(Hospedes: hospedes, Acomodacao: suite, DiasReserva: 10);
reserva.CadastrarSuite(suite);

hospedes.Add(p2);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");