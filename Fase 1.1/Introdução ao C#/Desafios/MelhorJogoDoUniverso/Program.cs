Introducao();

int tentativas = 3;
string nomeDoJogo;
string melhorJogoDoUniverso = "Half Life 3";

nomeDoJogo = LerResposta("Qual é o melhor jogo do universo?! -> ");

bool nomeErrado = nomeDoJogo != melhorJogoDoUniverso;

if(nomeErrado) {

    tentativas--;

    Console.WriteLine($"Resposta errada! Você tem {tentativas} tentativas.");

    nomeDoJogo = LerResposta("Qual é o melhor jogo do universo?! -> ");

    nomeErrado = nomeDoJogo != melhorJogoDoUniverso;
    
    if(nomeErrado) {
        
        tentativas--;

        Console.WriteLine("Resposta errada! Sua batata está assando!");

        nomeDoJogo = LerResposta("Qual é o melhor jogo do universo?! -> ");

        nomeErrado = nomeDoJogo != melhorJogoDoUniverso;

        if(nomeErrado) {

            tentativas--;

            Console.WriteLine("Você não sabe de nada mesmo... Vou procurar alguem que entende de jogos");
        
            Console.ReadKey();

        }else {
            RespostaCorreta();
        }     
    }else {
            RespostaCorreta();
    }
}
else {
    RespostaCorreta();
}

static void Introducao() {
    Console.WriteLine("Olá, sou um gênio e posso de conceder 3 desejos...");
    Console.ReadKey();

    Console.WriteLine("Mas antes, você tem que responder uma pergunta. Você tem 3 tentativas.");
    Console.ReadKey();

}

static string LerResposta(string message) {

    Console.Write(message);
    return Console.ReadLine();
}

static void RespostaCorreta() {

    Console.WriteLine("Você acertou! Agora vou conceder seu desejos.");
    Console.ReadKey();
}
