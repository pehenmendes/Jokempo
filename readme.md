# Jokenpô em C# (Pedra, Papel e Tesoura)

## 📌 Descrição do Projeto

Este projeto consiste em um **jogo de Jokenpô (Pedra, Papel e Tesoura)** desenvolvido em **C# para execução em console**.
O jogo permite que um **jogador humano jogue contra a máquina**, registrando seu nome e armazenando estatísticas das partidas.

O sistema foi desenvolvido com foco em **boas práticas de programação**, como **modularização, validação de entrada e organização do código em métodos**.

---

## 🎮 Funcionalidades

O programa possui as seguintes funcionalidades:

* Registrar o **nome do jogador**
* Permitir **trocar de jogador**
* Jogar **Pedra, Papel ou Tesoura contra a máquina**
* **Gerar escolhas aleatórias da máquina**
* **Validar entradas do usuário**
* **Registrar estatísticas de cada jogador**
* Exibir **vitórias, derrotas e empates**
* Mostrar **estatísticas de todos os jogadores cadastrados**

---

## 🧠 Regras do Jogo

O jogo segue as regras clássicas do Jokenpô:

* **Pedra vence Tesoura**
* **Tesoura vence Papel**
* **Papel vence Pedra**
* Se ambos escolherem a mesma opção → **Empate**

---

## 🏗️ Estrutura do Programa

O código foi organizado em **métodos para facilitar a leitura, manutenção e reutilização**.

### Principais Métodos

| Método                    | Descrição                                   |
| ------------------------- | ------------------------------------------- |
| `Main()`                  | Controla o fluxo principal do programa      |
| `Menu()`                  | Exibe o menu de opções                      |
| `Jogar()`                 | Executa uma rodada do jogo                  |
| `VerificarResultado()`    | Determina o vencedor da rodada              |
| `AtualizarEstatisticas()` | Atualiza os dados do jogador                |
| `TrocarJogador()`         | Permite cadastrar ou trocar o jogador atual |
| `MostrarEstatisticas()`   | Exibe as estatísticas de todos os jogadores |
| `LerInteiro()`            | Valida a entrada numérica do usuário        |
| `ConverterEscolha()`      | Converte número em Pedra, Papel ou Tesoura  |

---

## 📊 Estrutura de Dados

O projeto utiliza:

* **Dictionary** para armazenar jogadores e estatísticas
* **Classe Estatistica** para guardar:

  * Vitórias
  * Derrotas
  * Empates

Exemplo conceitual:

```
Jogadores
 ├── Pedro
 │   ├── Vitórias
 │   ├── Derrotas
 │   └── Empates
 │
 ├── Maria
 │   ├── Vitórias
 │   ├── Derrotas
 │   └── Empates
```

---

## ▶️ Como Executar o Projeto

### 1️⃣ Pré-requisitos

* .NET SDK instalado
* Visual Studio ou Visual Studio Code (opcional)

### 2️⃣ Compilar o programa

No terminal:

```bash
dotnet new console
```

Substitua o conteúdo do arquivo **Program.cs** pelo código do projeto.

### 3️⃣ Executar

```bash
dotnet run
```

---

## 💻 Exemplo de Execução

```
=== JOGO JOKENPO ===

Digite o nome do jogador: Pedro

Jogador atual: Pedro
1 - Jogar
2 - Trocar jogador
3 - Ver estatísticas
0 - Sair

Escolha uma opção: 1

Escolha:
1 - Pedra
2 - Papel
3 - Tesoura

Máquina escolheu: Papel
Resultado: Derrota
```

---

## 🎯 Objetivo Educacional

Este projeto foi desenvolvido com o objetivo de praticar conceitos fundamentais de programação em C#:

* Estruturas condicionais
* Estruturas de repetição
* Métodos e modularização
* Validação de dados
* Estruturas de dados (Dictionary)
* Programação orientada a objetos básica

---

## 🚀 Possíveis Melhorias

Algumas melhorias que podem ser implementadas futuramente:

* Salvar estatísticas em **arquivo (JSON ou TXT)**
* Criar **ranking de jogadores**
* Adicionar **placar por rodada**
* Implementar **interface gráfica**
* Criar **modo melhor de 3 ou melhor de 5**

---

## 👨‍💻 Autor
- **Pedro Henrique Mendes dos Santos (RM555332)**

Projeto desenvolvido para fins educacionais na disciplina de **C# Software Development**.
