using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HollowKnightAPI.Models.Enuns;
using HollowKnightAPI.models;

namespace HollowKnightAPI.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class MobsController : ControllerBase
    {
        private static List<Mob> mobs = new List<Mob>()
        {
            new Mob()  {Id = 1, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Localizacao = "Encruzilhada esquecida", Lore = "Falso Cavaleiro é um Verme vestindo a armadura de Hegemol, um dos Cinco Cavaleiros Reais de Hallownest. Esta criatura fraca queria encontrar meios de proteger seus irmãos que vivem em um depósito abandonado no meio da Encruzilhada Esquecida. Quando ele descobriu Hegemol dormindo em sua concha blindada, ele a pegou para si, esperando pela grande força que usar a armadura parecia prometer. Mesmo que a loucura não o tenha levado a fazer isso, o Falso Cavaleiro acabou caindo nas mãos da Infecção.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 2, Nome = "Mãe Mosca", PontosVida = 90, Forca = 1, Dificultade = "E", Localizacao = "Encruzilhada Esquecida", Lore = "Uma Mãe Mosca pode ser encontrada bloqueando o caminho direto para uma vila abandonada no fundo da Encruzilhada Esquecida. Ela está dormindo, exausta de carregar seus filhos, e acorda quando é atingida. Após a derrota, seu estômago explode para revelar um enxame de Moscas.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 3, Nome = "Rei Vengemosca", PontosVida = 55, Forca = 1, Dificultade = "E", Localizacao = "Caminho Verde", Lore = "Reis Vengemoscas são os patriarcas territoriais das Vengemoscas e são nativos do Caminho Verde.[", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 4, Nome = "Hornet Protetora", PontosVida = 225, Forca = 1, Dificultade = "D", Localizacao = "Caminho Verde", Lore = "Hornet é a misteriosa princesa-protetora das ruínas de Hallownest, uma personagem importante de Hollow Knight e protagonista de Hollow Knight: Silksong.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 5, Nome = "Batedor Musgoso Imenso", PontosVida = 480, Forca = 1, Dificultade = "E", Localizacao = "Caminho Verde", Lore = "O Batedor Musgoso Imenso é um mini-chefe opcional no Hollow Knight e encontramos no caminho verde. ", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 6, Nome = "Lordes Louva-a-Deus", PontosVida = 530, Forca = 1, Dificultade = "B", Localizacao = "Ermos Fúngicos", Lore = "As Lordes Louva-a-Deus são três irmãs que comandam a Tribo-Louva-a-Deus nas profundezas dos Ermos Fúngicos. Eles conseguiram resistir à Infecção durante a queda de Hallownest, exceto o irmão e seus seguidores, que escolheram aceitar a Infecção voluntariamente.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 7, Nome = "Guerreiro das Almas", PontosVida = 175, Forca = 1, Dificultade = "C", Localizacao = "Santuário das Almas", Lore = "???", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 8, Nome = "Mestre das Almas", PontosVida = 385, Forca = 1, Dificultade = "B", Localizacao = "Santuário das Almas", Lore = "O Mestre das Almas é o líder do Santuário das Almas de Hallownest, que procurou maneiras de expandir as mentes dos insetos e atingir o foco puro. Quando a Infecção começou, ele chegou à conclusão de que ALMA, a energia que anima insetos e bestas, era a solução para curar as suas mentes dessa praga. Ele se recusou a ouvir o Rei Pálido se opondo ao seu trabalho, e não pôde perceber que a sua própria mente Infectada estava o influenciando.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 9, Nome = "Defensor do Esterco", PontosVida = 700, Forca = 1, Dificultade = "B", Localizacao = "Hidrovia Real", Lore = "O Defensor do Esterco costumava ser conhecido como Ogrim, o mais leal dos Cinco Grandes Cavaleiros de Hallownest. Como tal, ele participou de muitas batalhas e aventuras. Ele também era igualmente famoso por seu mau cheiro, embora isso não o impedisse de desfrutar da companhia da Dama Branca e seus companheiros cavaleiros. Ele gostava particularmente da cavaleira Isma.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 10, Nome = "Flukemarm", PontosVida = 350, Forca = 1, Dificultade = "E", Localizacao = "Hidrovia Real", Lore = "Flukemarm é a mãe de todos os Flukes que infestam a Hidrovia Real. Seu corpo é usado como um ninho para Flukefeys jovens. Assim como seus filhos, ela foi Infectada e hostilizada, embora sua condição de reprodutora a impeça de sair de sua caverna.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 11, Nome = "Receptáculo Quebrado", PontosVida = 525, Forca = 1, Dificultade = "B", Localizacao = "Bacia Antiga", Lore = "O Receptáculo Quebrado é um dos vários Receptáculos que escapou do O Abismo. Porém, diferente do Cavaleiro, ele teve uma morte trágica enquanto ainda estava em Hallownest. Sua carcaça foi abandonada em uma profunda caverna ventosa na Bacia Antiga a frente da região que fica as Asas do Monarca onde a Infecção tomou conta.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 12, Nome = "Guardião de Cristal", PontosVida = 280, Forca = 1, Dificultade = "C", Localizacao = "Pico de Cristal", Lore = "O Guardião Cristalizado faz parte dos mineradores do Pico de Cristal que morreram pela Infecção e foram reanimados por ela. Ele parece maior do que as outras carcaças, tem cristais crescendo em suas costas e envolvendo seus braços e sua cabeça. Ele também tem mais domínio sobre a luz do cristal do que as Carcaças Cristalizadas.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 13, Nome = "Mawlek Incubador", PontosVida = 300, Forca = 1, Dificultade = "C", Localizacao = "Encruzilhada Esquecida", Lore = "Um solitário Mawlek Incubador pode ser encontrado fora do caminho na Encruzilhada Esquecida, longe do seu irmão vivo na Bacia Antiga. Ele fica em meio a restos fossilizados de seus parentes, pedindo que reproduzam. Essa besta selvagem foi conduzida tanto pela solidão quanto pela Infecção que começou cobrindo seu corpo com bulbos.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 13, Nome = "Lorde Traidor", PontosVida = 800, Forca = 2, Dificultade = "A", Localizacao = "Jardins da Rainha", Lore = "O Lorde Traidor foi um dos líderes da Tribo Louva-a-Deus, junto de suas irmãs, além de ser particularmente ressentido a respeito de Hallownest.[2] De forma semelhante, ele desaprovava o relacionamento de sua filha com a Pranteadora Cinzenta, por ela ser um ser de fora.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 14, Nome = "Cavaleiro Sentinela", PontosVida = 100, Forca = 1, Dificultade = "A", Localizacao = "Cidade das Lágrimas", Lore = "???", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 15, Nome = "Uumuu", PontosVida = 300, Forca = 1, Dificultade = "C", Localizacao = "Arquivos da Professora", Lore = "Uumuu é um ser inteligente, porém Infectado, semelhante aos Uomas e Oomas que infestam o Cânion da Névoa. É responsável por defender a câmara de Monomon no coração dos Arquivos da Professora.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 16, Nome = "O Colecionador", PontosVida = 750, Forca = 1, Dificultade = "C", Localizacao = "Torre do Amor", Lore = "O Colecionador é uma criatura feita de Vazio. Ele vive escondido na Torre do Amor trancado junto com uma grande coleção de insetos de toda Hallownest que são preservados, vivos ou mortos, em jarras de vidro.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 17, Nome = "Hornet Sentinela", PontosVida = 700, Forca = 1, Dificultade = "A", Localizacao = "Borda do Reino", Lore = "Hornet Sentinela é a segunda forma de Hornet como uma chefe em Hollow Knight. Ela desafia o Cavaleiro na entrada da Casca Descartada na Borda do Reino para testar sua determinação e força para salvar Hallownest. Dessa vez, ela emprega toda a sua força e ferramentas.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 18, Nome = "Nosk", PontosVida = 680, Forca = 1, Dificultade = "A", Localizacao = "Ninho Profundo", Lore = "Nosk é uma besta Infectada misteriosa e metamórfica caçando no Ninho Profundo. Ele pode imitar a forma de rostos que encontra nas memórias de insetos, geralmente entes queridos ou falecidos, e pode contorcer seu corpo para assumir uma moldura menor. Ele pendura suas presas, incluindo Escavadores, um Devoto Espreitador, e vários Receptáculos, no teto do seu covil no fundo do Ninho Profundo.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 19, Nome = "Cavaleiro da Colmeia", PontosVida = 800, Forca = 1, Dificultade = "A", Localizacao = "Colmeia", Lore = "Cavaleiro da Colmeia é o cavaleiro mais valente e habilidoso da Colmeia; ele não voa e é obrigado a proteger a Rainha da Colmeia Vespa pela mente coletiva das Abelhas. Embora a Infecção tenha se espalhado para a Colmeia depois que a rainha morreu, o Cavaleiro da Colmeia ainda a protege, esperando que ela um dia acorde e reviva a Colmeia.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 20, Nome = "Oblobles", PontosVida = 560, Forca = 1, Dificultade = "C", Localizacao = "Coliseu dos Tolos", Lore = "Os Obbles são parentes maiores do Obble e são capazes de se mover mais rápido e disparar mais projéteis por ataque. O Cavaleiro pode encontrar dois deles no Coliseu dos Tolos durante o Julgamento do Conquistador. Esses Oblobbles são criados e treinados dentro do Coliseu para participar da luta contra os gladiadores. Matar um enfurece o outro e faz com que ele se mova e ataque mais rápido.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 21, Nome = "Domador de Deuses", PontosVida = 105, Forca = 1, Dificultade = "B", Localizacao = "Coliseu dos Tolos", Lore = "A Domadora de Deuses é uma guerreira veterana do Coliseu dos Tolos, tomando o lugar de chefe do último e mais brutal julgamento. Ela compensa por sua pequena estatura com a força de sua Besta domesticada, ao lado da qual ela luta. Ambos apresentam sinais da Infecção.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 22, Nome = "Cavaleiro Vazio", PontosVida = 1250, Forca = 1, Dificultade = "S", Localizacao = "Ovo Negro", Lore = "O Cavaleiro Vazio é um Receptáculo escolhido pelo Rei Pálido para selar a Radiância e salvar Hallownest da Infecção. Como seus irmãos, ele era um filho do Rei e da Rainha de Hallownest, nascido no Abismo e preenchido com o poder do Vazio. Sendo assim, nenhum deles tem gênero. A condição desse nascimento consequentemente os deixaria sem mente, vontade ou voz, para prevenir que A Radiância não os influenciasse. No entanto, sua pureza foi mal avaliada, manchada por uma ideia instintiva, o laço com o Rei Pálido, aquele que os criou.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 23, Nome = "Radiância", PontosVida = 1700, Forca = 2, Dificultade = "S", Localizacao = "Cavaleiro Vazio", Lore = "A Radiância é um ser superior de luz semelhante à Essência e, como tal, oposta ao Vazio , seu antigo inimigo. A Tribo Mariposa nasce de sua luz e em troca a reverencia.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 24, Nome = "Ancião Hu", PontosVida = 250, Forca = 1, Dificultade = "B", Localizacao = "Cidade das Lágrimas", Lore = "Ancião Hu era um sábio viajante que procurou purificar as fronteiras de Hallownest da Infecção. Ele alcançou a Vila Louva-a-Deus, mas sua própria mente Infectada o fez ver os Lordes Louva-a-Deus e a Tribo como afligidos pela praga. Os Louva-a-Deus o mataram depois que ele os atacou. Um memorial foi erguido em seu nome acima dos portões da Cidade das Lágrimas, com sua túnica e colar de contas repousando sobre o memorial.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 25, Nome = "Galien", PontosVida = 650, Forca = 1, Dificultade = "B", Localizacao = "Ninho Profundo", Lore = "Galien era um guerreiro corajoso e invicto que dizia ser o mais forte em Hallownest e desejava provar seu valor ao Rei Pálido como um Cavaleiro. Ele viajou para Ninho Profundo para testar sua força, mas acabou encontrando a morte. Sua casca está em uma caverna cheia de cogumelos brilhantes incomumente grandes abaixo da Linha de Bonde Inacabada em Ninho Profundo.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 26, Nome = "Gorb", PontosVida = 320, Forca = 1, Dificultade = "B", Localizacao = "Pico Uivante", Lore = "Gorb, a Grande Mente, era uma criatura mística com um cérebro distendido que afirmava ser onisciente. Eles incitaram outros a reverenciar suas mentes e ascender com eles a um plano diferente de existência. Seus restos mortais foram enterrados em uma colina no topo dos Penhascos Uivantes, com uma lápide esculpida em sua imagem. O fantasma de Gorb aparece em seu túmulo após adquirir o ferrão dos sonhos.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 27, Nome = "Markoth", PontosVida = 105, Forca = 1, Dificultade = "A", Localizacao = "Borda do Reino", Lore = "Markoth é uma Mariposa. Aparentemente amigo de Thistlewind, eles são as únicas Mariposas a empunhar um ferrão de forma agressiva, sendo encontrado na borda do reino, dando 250 essências como recompensa.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 28, Nome = "Marmu", PontosVida = 200, Forca = 1, Dificultade = "C", Localizacao = "Jardins da Rainha", Lore = "Marmu foi uma protetora inocente, porém forte, dos Jardins da Rainha. A Rainha prometeu ensiná-la a como voar quando retornasse ao seu retiro verdejante. Marmu faleceu antes desse dia, e um totem em sua memória foi erguido em seu túmulo nos confins do jardim.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 29, Nome = "Sem Olhos", PontosVida = 320, Forca = 1, Dificultade = "C", Localizacao = "Caminho Verde", Lore = "Sem olhos (No Eyes) foi um guerreiro do Hallownest que caiu na infecção. Ela não conseguia dormir sabendo que os sonhos infectariam sua mente com a luz. Para proteger a si mesma e a outros insetos, ela arrancou seus olhos e os dela antes de sucumbir. Ela foi sepultada no Santuário de Pedra, um lugar completamente escuro, e uma estátua esculpida foi colocada sobre seu túmulo.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 30, Nome = "Xero", PontosVida = 320, Forca = 1, Dificultade = "B", Localizacao = "Terra do Descanso", Lore = "Xero era um guerreiro de Hallownest que acreditava que a força sempre lhe permitiria um futuro brilhante. Quando sua mente foi infectada, ele esperava lutar contra a praga com violência.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 31, Nome = "Campeão Fracassado", PontosVida = 1260, Forca = 2, Dificultade = "A", Localizacao = "Encruzilhada Esquecida", Lore = "Campeão Fracassado é um chefe escondido em Hollow Knight. Ele é a variante dos Sonhos do Falso Cavaleiro, sendo mais forte e ágil do que o seu equivalente físico.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 32, Nome = "Parente Perdido", PontosVida = 1200, Forca = 1, Dificultade = "A", Localizacao = "Bacia Antiga", Lore = "Parente Perdido é um chefe oculto em Hollow Knight. É a variante dos Sonhos do Receptáculo Quebrado, mais rápida e mais resistente do que sua contraparte física.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 33, Nome = "Príncipe Cinza Zote", PontosVida = 1, Forca = 2, Dificultade = "SS", Localizacao = "Dirmouth", Lore = "???", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 34, Nome = "Defensor Branco", PontosVida = 105, Forca = 1, Dificultade = "S", Localizacao = "Hidrovia Real", Lore = "Defensor Branco é um chefe oculto em Hollow Knight. É a variante dos Sonhos do Defensor de Esterco", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 35, Nome = "Grimm", PontosVida = 1000, Forca = 1, Dificultade = "S", Localizacao = "Dirmouth (DLC)", Lore = "Grimm é o lider da Trupe Grimm, da DLC The Grimm Troupe, um misterioso circo itinerante.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 36, Nome = "Rei do Pesadelo Grimm", PontosVida = 1500, Forca = 2, Dificultade = "SS", Localizacao = "Dirmouth (DLC)", Lore = "Rei do Pesadelo Grimm é o chefe final opcional de A Trupe Grimm em Hollow Knight. Ele é a forma dos Sonhos do Mestre da Trupe Grimm.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 37, Nome = "Receptáculo Puro", PontosVida = 1600, Forca = 2, Dificultade = "SS", Localizacao = "Panteão de Hollownest", Lore = "O Receptáculo Puro é um chefe opcional de Hollow Knight introduzido em Deus Mestre. Ele é a forma primordial do Cavaleiro Vazio, a forma não afetada pela Infecção.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 38, Nome = "Guardião Enfurecido", PontosVida = 280, Forca = 2, Dificultade = "A", Localizacao = "Pico de Cristal", Lore = "Guardião Enfurecido é um chefe em Hollow Knight. É a variante do Guardião Cristalizado", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 39, Nome = "Nosk Alado", PontosVida = 750, Forca = 1, Dificultade = "S", Localizacao = "Panteão de Hollownest", Lore = "Nosk Alado é um chefe em Hollow Knight introduzido em Deus Mestre. É a forma voadora de Nosk, assumindo a forma da Hornet no início, em vez do Cavaleiro. Ele pode ser encontrado no Panteão de Hallownest.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 40, Nome = "Tirano das Almas", PontosVida = 1250, Forca = 1, Dificultade = "A", Localizacao = "Santuário das Almas", Lore = "O Tirano das Almas é um chefe oculto em Hollow Knight. É a variante dos sonhos do Mestre das Almas, mais rápido e mais resistente do que sua contraparte física.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 41, Nome = "Zote o Poderoso", PontosVida = 200, Forca = 0, Dificultade = "E", Localizacao = "Coliseu dos Tolos", Lore = "Zote o Poderoso é um NPC em Hollow Knight. É um viajante de fora de Hallownest que veio para cumprir uma promessa.", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 42, Nome = "Radiância Absoluta", PontosVida = 1700, Forca = 2, Dificultade = "SS", Localizacao = "Panteão de Hollownest", Lore = "A Radiância é um chefe secreto em Hollow Knight. Godmaster Icon Radiância Absoluta é sua forma perfeita que é encontrada no topo do panteão de Hallownest.", Categoria = CategoriaEnum.Boss},
        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            return Ok(mobs[0]);
        }

        [HttpGet("GetAll")]

        public IActionResult Get()
        {
            return Ok(mobs);
        }
    }
}