IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_MOBS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [PontosVida] int NULL,
    [Forca] int NULL,
    [Dificultade] nvarchar(max) NULL,
    [Localizacao] nvarchar(max) NULL,
    [Lore] nvarchar(max) NULL,
    [Foto] nvarchar(max) NULL,
    [Categoria] int NOT NULL,
    CONSTRAINT [PK_TB_MOBS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Categoria', N'Dificultade', N'Forca', N'Foto', N'Localizacao', N'Lore', N'Nome', N'PontosVida') AND [object_id] = OBJECT_ID(N'[TB_MOBS]'))
    SET IDENTITY_INSERT [TB_MOBS] ON;
INSERT INTO [TB_MOBS] ([Id], [Categoria], [Dificultade], [Forca], [Foto], [Localizacao], [Lore], [Nome], [PontosVida])
VALUES (1, 1, N'E', 1, N'https://static.wikia.nocookie.net/hollowknight/images/c/c2/False_Knight_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005213247', N'Encruzilhada esquecida', N'Falso Cavaleiro é um Verme vestindo a armadura de Hegemol, um dos Cinco Cavaleiros Reais de Hallownest. Esta criatura fraca queria encontrar meios de proteger seus irmãos que vivem em um depósito abandonado no meio da Encruzilhada Esquecida. Quando ele descobriu Hegemol dormindo em sua concha blindada, ele a pegou para si, esperando pela grande força que usar a armadura parecia prometer. Mesmo que a loucura não o tenha levado a fazer isso, o Falso Cavaleiro acabou caindo nas mãos da Infecção.', N'O Falso Cavaleiro', 105),
(2, 1, N'E', 1, N'https://static.wikia.nocookie.net/hollowknight/images/e/e2/Gruz_Mother_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005205907', N'Encruzilhada Esquecida', N'Uma Mãe Mosca pode ser encontrada bloqueando o caminho direto para uma vila abandonada no fundo da Encruzilhada Esquecida. Ela está dormindo, exausta de carregar seus filhos, e acorda quando é atingida. Após a derrota, seu estômago explode para revelar um enxame de Moscas.', N'Mãe Mosca', 90),
(3, 1, N'E', 1, N'https://static.wikia.nocookie.net/hollowknight/images/0/08/Vengefly_King_Icon.png/revision/latest/scale-to-width-down/100?cb=20180827013512', N'Caminho Verde', N'Reis Vengemoscas são os patriarcas territoriais das Vengemoscas e são nativos do Caminho Verde.[', N'Rei Vengemosca', 55),
(4, 1, N'D', 1, N'https://static.wikia.nocookie.net/hollowknight/images/e/e9/Hornet_Protector_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005204201', N'Caminho Verde', N'Hornet é a misteriosa princesa-protetora das ruínas de Hallownest, uma personagem importante de Hollow Knight e protagonista de Hollow Knight: Silksong.', N'Hornet Protetora', 225),
(5, 1, N'E', 1, N'https://static.wikia.nocookie.net/hollowknight/images/3/3d/Massive_Moss_Charger_Icon.png/revision/latest/scale-to-width-down/100?cb=20180827013444', N'Caminho Verde', N'O Batedor Musgoso Imenso é um mini-chefe opcional no Hollow Knight e encontramos no caminho verde. ', N'Batedor Musgoso Imenso', 480),
(6, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/b/b2/Mantis_Lords_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511203618', N'Ermos Fúngicos', N'As Lordes Louva-a-Deus são três irmãs que comandam a Tribo-Louva-a-Deus nas profundezas dos Ermos Fúngicos. Eles conseguiram resistir à Infecção durante a queda de Hallownest, exceto o irmão e seus seguidores, que escolheram aceitar a Infecção voluntariamente.', N'Lordes Louva-a-Deus', 530),
(7, 1, N'C', 1, N'https://static.wikia.nocookie.net/hollowknight/images/0/0c/Soul_Warrior_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005211941', N'Santuário das Almas', N'???', N'Guerreiro das Almas', 175),
(8, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/e/e9/Soul_Master_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005205259', N'Santuário das Almas', N'O Mestre das Almas é o líder do Santuário das Almas de Hallownest, que procurou maneiras de expandir as mentes dos insetos e atingir o foco puro. Quando a Infecção começou, ele chegou à conclusão de que ALMA, a energia que anima insetos e bestas, era a solução para curar as suas mentes dessa praga. Ele se recusou a ouvir o Rei Pálido se opondo ao seu trabalho, e não pôde perceber que a sua própria mente Infectada estava o influenciando.', N'Mestre das Almas', 385),
(9, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/b/bd/Dung_Defender_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511203423', N'Hidrovia Real', N'O Defensor do Esterco costumava ser conhecido como Ogrim, o mais leal dos Cinco Grandes Cavaleiros de Hallownest. Como tal, ele participou de muitas batalhas e aventuras. Ele também era igualmente famoso por seu mau cheiro, embora isso não o impedisse de desfrutar da companhia da Dama Branca e seus companheiros cavaleiros. Ele gostava particularmente da cavaleira Isma.', N'Defensor do Esterco', 700),
(10, 1, N'E', 1, N'https://static.wikia.nocookie.net/hollowknight/images/6/61/Flukemarm_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005212623', N'Hidrovia Real', N'Flukemarm é a mãe de todos os Flukes que infestam a Hidrovia Real. Seu corpo é usado como um ninho para Flukefeys jovens. Assim como seus filhos, ela foi Infectada e hostilizada, embora sua condição de reprodutora a impeça de sair de sua caverna.', N'Flukemarm', 350),
(11, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/e/e6/Broken_Vessel_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511203343', N'Bacia Antiga', N'O Receptáculo Quebrado é um dos vários Receptáculos que escapou do O Abismo. Porém, diferente do Cavaleiro, ele teve uma morte trágica enquanto ainda estava em Hallownest. Sua carcaça foi abandonada em uma profunda caverna ventosa na Bacia Antiga a frente da região que fica as Asas do Monarca onde a Infecção tomou conta.', N'Receptáculo Quebrado', 525),
(12, 1, N'C', 1, N'https://static.wikia.nocookie.net/hollowknight/images/a/af/Crystal_Guardian_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005210132', N'Pico de Cristal', N'O Guardião Cristalizado faz parte dos mineradores do Pico de Cristal que morreram pela Infecção e foram reanimados por ela. Ele parece maior do que as outras carcaças, tem cristais crescendo em suas costas e envolvendo seus braços e sua cabeça. Ele também tem mais domínio sobre a luz do cristal do que as Carcaças Cristalizadas.', N'Guardião de Cristal', 280),
(13, 1, N'C', 1, N'https://static.wikia.nocookie.net/hollowknight/images/6/6f/Brooding_Mawlek_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511203411', N'Encruzilhada Esquecida', N'Um solitário Mawlek Incubador pode ser encontrado fora do caminho na Encruzilhada Esquecida, longe do seu irmão vivo na Bacia Antiga. Ele fica em meio a restos fossilizados de seus parentes, pedindo que reproduzam. Essa besta selvagem foi conduzida tanto pela solidão quanto pela Infecção que começou cobrindo seu corpo com bulbos.', N'Mawlek Incubador', 300),
(14, 1, N'A', 2, N'https://static.wikia.nocookie.net/hollowknight/images/1/15/Traitor_Lord_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005205522', N'Jardins da Rainha', N'O Lorde Traidor foi um dos líderes da Tribo Louva-a-Deus, junto de suas irmãs, além de ser particularmente ressentido a respeito de Hallownest.[2] De forma semelhante, ele desaprovava o relacionamento de sua filha com a Pranteadora Cinzenta, por ela ser um ser de fora.', N'Lorde Traidor', 800),
(15, 1, N'A', 1, N'https://static.wikia.nocookie.net/hollowknight/images/b/b3/Watcher_Knight_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005211823', N'Cidade das Lágrimas', N'???', N'Cavaleiro Sentinela', 100),
(16, 1, N'C', 1, N'https://static.wikia.nocookie.net/hollowknight/images/d/d9/Uumuu_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511210950', N'Arquivos da Professora', N'Uumuu é um ser inteligente, porém Infectado, semelhante aos Uomas e Oomas que infestam o Cânion da Névoa. É responsável por defender a câmara de Monomon no coração dos Arquivos da Professora.', N'Uumuu', 300),
(17, 1, N'C', 1, N'https://hollowknight.fandom.com/wiki/Brothers_Oro_%26_Mato', N'Torre do Amor', N'O Colecionador é uma criatura feita de Vazio. Ele vive escondido na Torre do Amor trancado junto com uma grande coleção de insetos de toda Hallownest que são preservados, vivos ou mortos, em jarras de vidro.', N'O Colecionador', 750),
(18, 1, N'A', 1, N'https://static.wikia.nocookie.net/hollowknight/images/e/e9/Hornet_Protector_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005204201', N'Borda do Reino', N'Hornet Sentinela é a segunda forma de Hornet como uma chefe em Hollow Knight. Ela desafia o Cavaleiro na entrada da Casca Descartada na Borda do Reino para testar sua determinação e força para salvar Hallownest. Dessa vez, ela emprega toda a sua força e ferramentas.', N'Hornet Sentinela', 700),
(19, 1, N'A', 1, N'https://static.wikia.nocookie.net/hollowknight/images/8/8a/Nosk_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511203627', N'Ninho Profundo', N'Nosk é uma besta Infectada misteriosa e metamórfica caçando no Ninho Profundo. Ele pode imitar a forma de rostos que encontra nas memórias de insetos, geralmente entes queridos ou falecidos, e pode contorcer seu corpo para assumir uma moldura menor. Ele pendura suas presas, incluindo Escavadores, um Devoto Espreitador, e vários Receptáculos, no teto do seu covil no fundo do Ninho Profundo.', N'Nosk', 680),
(20, 1, N'A', 1, N'https://static.wikia.nocookie.net/hollowknight/images/5/5f/Hive_Knight_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005210625', N'Colmeia', N'Cavaleiro da Colmeia é o cavaleiro mais valente e habilidoso da Colmeia; ele não voa e é obrigado a proteger a Rainha da Colmeia Vespa pela mente coletiva das Abelhas. Embora a Infecção tenha se espalhado para a Colmeia depois que a rainha morreu, o Cavaleiro da Colmeia ainda a protege, esperando que ela um dia acorde e reviva a Colmeia.', N'Cavaleiro da Colmeia', 800),
(21, 1, N'C', 1, N'https://static.wikia.nocookie.net/hollowknight/images/6/66/Oblobble_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005204959', N'Coliseu dos Tolos', N'Os Obbles são parentes maiores do Obble e são capazes de se mover mais rápido e disparar mais projéteis por ataque. O Cavaleiro pode encontrar dois deles no Coliseu dos Tolos durante o Julgamento do Conquistador. Esses Oblobbles são criados e treinados dentro do Coliseu para participar da luta contra os gladiadores. Matar um enfurece o outro e faz com que ele se mova e ataque mais rápido.', N'Oblobles', 560),
(22, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/1/19/God_Tamer_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005211000', N'Coliseu dos Tolos', N'A Domadora de Deuses é uma guerreira veterana do Coliseu dos Tolos, tomando o lugar de chefe do último e mais brutal julgamento. Ela compensa por sua pequena estatura com a força de sua Besta domesticada, ao lado da qual ela luta. Ambos apresentam sinais da Infecção.', N'Domador de Deuses', 105),
(23, 1, N'S', 1, N'https://static.wikia.nocookie.net/hollowknight/images/2/24/The_Hollow_Knight_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005212233', N'Ovo Negro', N'O Cavaleiro Vazio é um Receptáculo escolhido pelo Rei Pálido para selar a Radiância e salvar Hallownest da Infecção. Como seus irmãos, ele era um filho do Rei e da Rainha de Hallownest, nascido no Abismo e preenchido com o poder do Vazio. Sendo assim, nenhum deles tem gênero. A condição desse nascimento consequentemente os deixaria sem mente, vontade ou voz, para prevenir que A Radiância não os influenciasse. No entanto, sua pureza foi mal avaliada, manchada por uma ideia instintiva, o laço com o Rei Pálido, aquele que os criou.', N'Cavaleiro Vazio', 1250),
(24, 1, N'S', 2, N'https://static.wikia.nocookie.net/hollowknight/images/b/b8/Radiance_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005204741', N'Cavaleiro Vazio', N'A Radiância é um ser superior de luz semelhante à Essência e, como tal, oposta ao Vazio , seu antigo inimigo. A Tribo Mariposa nasce de sua luz e em troca a reverencia.', N'Radiância', 1700),
(25, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/6/64/Elder_Hu_Icon.png/revision/latest/scale-to-width-down/97?cb=20181211041949', N'Cidade das Lágrimas', N'Ancião Hu era um sábio viajante que procurou purificar as fronteiras de Hallownest da Infecção. Ele alcançou a Vila Louva-a-Deus, mas sua própria mente Infectada o fez ver os Lordes Louva-a-Deus e a Tribo como afligidos pela praga. Os Louva-a-Deus o mataram depois que ele os atacou. Um memorial foi erguido em seu nome acima dos portões da Cidade das Lágrimas, com sua túnica e colar de contas repousando sobre o memorial.', N'Ancião Hu', 250),
(26, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/6/6f/Galien_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005214202', N'Ninho Profundo', N'Galien era um guerreiro corajoso e invicto que dizia ser o mais forte em Hallownest e desejava provar seu valor ao Rei Pálido como um Cavaleiro. Ele viajou para Ninho Profundo para testar sua força, mas acabou encontrando a morte. Sua casca está em uma caverna cheia de cogumelos brilhantes incomumente grandes abaixo da Linha de Bonde Inacabada em Ninho Profundo.', N'Galien', 650),
(27, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/2/27/Gorb_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005214152', N'Pico Uivante', N'Gorb, a Grande Mente, era uma criatura mística com um cérebro distendido que afirmava ser onisciente. Eles incitaram outros a reverenciar suas mentes e ascender com eles a um plano diferente de existência. Seus restos mortais foram enterrados em uma colina no topo dos Penhascos Uivantes, com uma lápide esculpida em sua imagem. O fantasma de Gorb aparece em seu túmulo após adquirir o ferrão dos sonhos.', N'Gorb', 320),
(28, 1, N'A', 1, N'https://static.wikia.nocookie.net/hollowknight/images/4/44/Markoth_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511213232', N'Borda do Reino', N'Markoth é uma Mariposa. Aparentemente amigo de Thistlewind, eles são as únicas Mariposas a empunhar um ferrão de forma agressiva, sendo encontrado na borda do reino, dando 250 essências como recompensa.', N'Markoth', 105),
(29, 1, N'C', 1, N'https://static.wikia.nocookie.net/hollowknight/images/1/10/Marmu_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511213232', N'Jardins da Rainha', N'Marmu foi uma protetora inocente, porém forte, dos Jardins da Rainha. A Rainha prometeu ensiná-la a como voar quando retornasse ao seu retiro verdejante. Marmu faleceu antes desse dia, e um totem em sua memória foi erguido em seu túmulo nos confins do jardim.', N'Marmu', 200),
(30, 1, N'C', 1, N'https://static.wikia.nocookie.net/hollowknight/images/7/79/No_Eyes_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511213232', N'Caminho Verde', N'Sem olhos (No Eyes) foi um guerreiro do Hallownest que caiu na infecção. Ela não conseguia dormir sabendo que os sonhos infectariam sua mente com a luz. Para proteger a si mesma e a outros insetos, ela arrancou seus olhos e os dela antes de sucumbir. Ela foi sepultada no Santuário de Pedra, um lugar completamente escuro, e uma estátua esculpida foi colocada sobre seu túmulo.', N'Sem Olhos', 320),
(31, 1, N'B', 1, N'https://static.wikia.nocookie.net/hollowknight/images/0/00/Xero_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511213232', N'Terra do Descanso', N'Xero era um guerreiro de Hallownest que acreditava que a força sempre lhe permitiria um futuro brilhante. Quando sua mente foi infectada, ele esperava lutar contra a praga com violência.', N'Xero', 320),
(32, 1, N'A', 2, N'https://static.wikia.nocookie.net/hollowknight/images/c/c2/False_Knight_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005213247', N'Encruzilhada Esquecida', N'Campeão Fracassado é um chefe escondido em Hollow Knight. Ele é a variante dos Sonhos do Falso Cavaleiro, sendo mais forte e ágil do que o seu equivalente físico.', N'Campeão Fracassado', 1260),
(33, 1, N'A', 1, N'https://static.wikia.nocookie.net/hollowknight/images/e/e6/Broken_Vessel_Icon.png/revision/latest/scale-to-width-down/100?cb=20170511203343', N'Bacia Antiga', N'Parente Perdido é um chefe oculto em Hollow Knight. É a variante dos Sonhos do Receptáculo Quebrado, mais rápida e mais resistente do que sua contraparte física.', N'Parente Perdido', 1200),
(34, 1, N'SS', 2, N'https://static.wikia.nocookie.net/hollowknight/images/8/81/Grey_Prince_Zote_Circle.png/revision/latest/scale-to-width-down/100?cb=20170810232902', N'Dirmouth', N'???', N'Príncipe Cinza Zote', 1),
(35, 1, N'S', 1, N'https://static.wikia.nocookie.net/hollowknight/images/8/80/White_defender_circle_.png/revision/latest/scale-to-width-down/99?cb=20170810232928', N'Hidrovia Real', N'Defensor Branco é um chefe oculto em Hollow Knight. É a variante dos Sonhos do Defensor de Esterco', N'Defensor Branco', 105),
(36, 1, N'S', 1, N'https://static.wikia.nocookie.net/hollowknight/images/2/23/Troupe_Master_Grimm_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005211608', N'Dirmouth (DLC)', N'Grimm é o lider da Trupe Grimm, da DLC The Grimm Troupe, um misterioso circo itinerante.', N'Grimm', 1000),
(37, 1, N'SS', 2, N'https://static.wikia.nocookie.net/hollowknight/images/c/c3/Nightmare_King_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005215902', N'Dirmouth (DLC)', N'Rei do Pesadelo Grimm é o chefe final opcional de A Trupe Grimm em Hollow Knight. Ele é a forma dos Sonhos do Mestre da Trupe Grimm.', N'Rei do Pesadelo Grimm', 1500),
(38, 1, N'SS', 2, N'https://static.wikia.nocookie.net/hollowknight/images/b/b1/Pure_Vessel_Icon.png/revision/latest/scale-to-width-down/100?cb=20180827013611', N'Panteão de Hollownest', N'O Receptáculo Puro é um chefe opcional de Hollow Knight introduzido em Deus Mestre. Ele é a forma primordial do Cavaleiro Vazio, a forma não afetada pela Infecção.', N'Receptáculo Puro', 1600),
(39, 1, N'A', 2, N'https://static.wikia.nocookie.net/hollowknight/images/a/af/Crystal_Guardian_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005210132', N'Pico de Cristal', N'Guardião Enfurecido é um chefe em Hollow Knight. É a variante do Guardião Cristalizado', N'Guardião Enfurecido', 280),
(40, 1, N'S', 1, N'https://static.wikia.nocookie.net/hollowknight/images/c/c1/Winged_Nosk_Icon.png/revision/latest/scale-to-width-down/100?cb=20180827013634', N'Panteão de Hollownest', N'Nosk Alado é um chefe em Hollow Knight introduzido em Deus Mestre. É a forma voadora de Nosk, assumindo a forma da Hornet no início, em vez do Cavaleiro. Ele pode ser encontrado no Panteão de Hallownest.', N'Nosk Alado', 750),
(41, 1, N'A', 1, N'https://static.wikia.nocookie.net/hollowknight/images/e/e9/Soul_Master_Icon.png/revision/latest/scale-to-width-down/100?cb=20181005205259', N'Santuário das Almas', N'O Tirano das Almas é um chefe oculto em Hollow Knight. É a variante dos sonhos do Mestre das Almas, mais rápido e mais resistente do que sua contraparte física.', N'Tirano das Almas', 1250),
(42, 1, N'E', 0, N'https://static.wikia.nocookie.net/hollowknight/images/1/12/Zote_Circle-2.png/revision/latest/scale-to-width-down/100?cb=20180831184143', N'Coliseu dos Tolos', N'Zote o Poderoso é um NPC em Hollow Knight. É um viajante de fora de Hallownest que veio para cumprir uma promessa.', N'Zote o Poderoso', 200);
INSERT INTO [TB_MOBS] ([Id], [Categoria], [Dificultade], [Forca], [Foto], [Localizacao], [Lore], [Nome], [PontosVida])
VALUES (43, 1, N'SS', 2, N'https://static.wikia.nocookie.net/hollowknight/images/6/68/Absolute_Radiance_Icon.png/revision/latest/scale-to-width-down/100?cb=20180827013551', N'Panteão de Hollownest', N'A Radiância é um chefe secreto em Hollow Knight. Godmaster Icon Radiância Absoluta é sua forma perfeita que é encontrada no topo do panteão de Hallownest.', N'Radiância Absoluta', 1700);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Categoria', N'Dificultade', N'Forca', N'Foto', N'Localizacao', N'Lore', N'Nome', N'PontosVida') AND [object_id] = OBJECT_ID(N'[TB_MOBS]'))
    SET IDENTITY_INSERT [TB_MOBS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231209210809_MigrationMobs', N'7.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_ITENS] (
    [Id] int NOT NULL IDENTITY,
    [IdItem] int NOT NULL,
    [NomeItem] nvarchar(max) NOT NULL,
    [FotoItem] nvarchar(max) NULL,
    [DescricaoItem] nvarchar(max) NULL,
    [CategoriaItem] int NOT NULL,
    CONSTRAINT [PK_TB_ITENS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoriaItem', N'DescricaoItem', N'FotoItem', N'IdItem', N'NomeItem') AND [object_id] = OBJECT_ID(N'[TB_ITENS]'))
    SET IDENTITY_INSERT [TB_ITENS] ON;
INSERT INTO [TB_ITENS] ([Id], [CategoriaItem], [DescricaoItem], [FotoItem], [IdItem], [NomeItem])
VALUES (1, 1, N'Sussura sua localização ao portador sempre que o mapa estiver aberto', N'https://static.wikia.nocookie.net/hollowknight/images/7/7d/Wayward_Compass.png/revision/latest/scale-to-width-down/76?cb=20231011215858&path-prefix=pt', 1, N'Bússula Caprichosa'),
(2, 1, N'Um enxame seguirá o portador e coletará quaisquer Geo deixado no chão.', N'https://static.wikia.nocookie.net/hollowknight/images/8/8a/Gathering_Swarm.png/revision/latest/scale-to-width-down/76?cb=20231011220242&path-prefix=pt', 2, N'Enxame de Colecionadores'),
(3, 1, N'Quando recuperando-se de dano recebido, o portador permanecerá invulnerável por mais tempo.', N'https://static.wikia.nocookie.net/hollowknight/images/f/f2/Stalwart_Shell.png/revision/latest/scale-to-width-down/76?cb=20230731195337&path-prefix=pt', 3, N'Carapaça Robusta'),
(4, 1, N'Aumenta a quantidade de ALMA recebida quando um oponente é atingido com o ferrão.', N'https://static.wikia.nocookie.net/hollowknight/images/c/ca/Soul_Catcher.png/revision/latest/scale-to-width-down/76?cb=20231011220646&path-prefix=pt', 4, N'Apanhador de Almas'),
(5, 1, N'Quando dano é recebido, brotam-se vinhas espinhentas que machucam inimigos próximos.', N'https://static.wikia.nocookie.net/hollowknight/images/6/6c/Soul_Eater.png/revision/latest/scale-to-width-down/76?cb=20230731195650&path-prefix=pt', 5, N'Pedra do Xamã'),
(6, 1, N'Aumenta consideravelmente a quantidade de ALMA recebida quando um oponente é atingido com o ferrão.', N'https://static.wikia.nocookie.net/hollowknight/images/7/7d/Wayward_Compass.png/revision/latest/scale-to-width-down/76?cb=20231011215858&path-prefix=pt', 6, N'Devorador de Almas'),
(7, 1, N'Permite que o portador esquive-se mais frequentemente assim como esquivar-se para baixo.', N'https://static.wikia.nocookie.net/hollowknight/images/8/8f/Thorns_of_Agony.png/revision/latest/scale-to-width-down/76?cb=20230802200324&path-prefix=pt', 7, N'Espinhos da Agonia'),
(8, 1, N'Quando próximo a morte, a força do portador irá aumentar.', N'https://static.wikia.nocookie.net/hollowknight/images/4/4f/Fury_of_the_Fallen.png/revision/latest/scale-to-width-down/76?cb=20230802203206&path-prefix=pt', 8, N'Fúria dos Caídos'),
(9, 1, N'Reduz o custo de ALMA para a canalização de magias', N'https://static.wikia.nocookie.net/hollowknight/images/3/33/Spell_Twister.png/revision/latest/scale-to-width-down/76?cb=20231011212430&path-prefix=pt', 9, N'Dobrador de Magias'),
(10, 1, N'Mantém seu portador firme, prevenindo-o de recuar quando atingir um inimigo com o Ferrão.', N'https://static.wikia.nocookie.net/hollowknight/images/f/f5/Steady_Body.png/revision/latest/scale-to-width-down/76?cb=20231011221422&path-prefix=pt', 10, N'Corpo Firme'),
(11, 1, N'Aumenta a força do ferrão do portador, causando inimigos a recuar mais quando atingidos.', N'https://static.wikia.nocookie.net/hollowknight/images/f/f6/Heavy_Blow.png/revision/latest/scale-to-width-down/76?cb=20231011222923&path-prefix=pt', 11, N'Golpe Pesado'),
(12, 1, N'Permite o portador cortar muito mais rapidamente com seu ferrão.', N'https://static.wikia.nocookie.net/hollowknight/images/5/5f/Quick_Slash.png/revision/latest/scale-to-width-down/76?cb=20231011223343&path-prefix=pt', 12, N'Corte Rápido'),
(13, 1, N'Aumenta o alcance do ferrão do portador.', N'https://static.wikia.nocookie.net/hollowknight/images/d/d1/Longnail.png/revision/latest/scale-to-width-down/76?cb=20231011223530&path-prefix=pt', 13, N'Ferrão Longo'),
(14, 1, N'Aumenta consideravelmente o alcance do ferrão do portador.', N'https://static.wikia.nocookie.net/hollowknight/images/6/69/Mark_of_Pride.png/revision/latest/scale-to-width-down/76?cb=20231011223649&path-prefix=pt', 14, N'Marca de Orgulho'),
(15, 1, N'Protege o portador com uma carapaça dura enquanto estiver focando ALMA.', N'https://static.wikia.nocookie.net/hollowknight/images/2/21/Baldur_Shell.png/revision/latest/scale-to-width-down/76?cb=20231011223844&path-prefix=pt', 15, N'Carapaça de Baldur'),
(16, 1, N'Transforma a magia Espirito Vingativo em uma horda de voláteis flukes bebês.', N'https://static.wikia.nocookie.net/hollowknight/images/7/7d/Wayward_Compass.png/revision/latest/scale-to-width-down/76?cb=20231011215858&path-prefix=pt', 16, N'Ninho de Flukes'),
(17, 1, N'Causa o portador a emitir um odor heróico.', N'https://static.wikia.nocookie.net/hollowknight/images/5/56/Defender%27s_Crest.png/revision/latest/scale-to-width-down/76?cb=20231011224240&path-prefix=pt', 17, N'Insignia do Defensor'),
(18, 1, N'Drena a ALMA de seu portador e utiliza-a para parir crias.', N'https://static.wikia.nocookie.net/hollowknight/images/c/c6/Glowing_Womb.png/revision/latest/scale-to-width-down/76?cb=20231011224432&path-prefix=pt', 18, N'Útero Brilhante'),
(19, 1, N'Aumenta a velocidade do foco da ALMA, permitindo que o portador se cure mais rapidamente.', N'https://static.wikia.nocookie.net/hollowknight/images/6/6a/Quick_Focus.png/revision/latest/scale-to-width-down/76?cb=20231011224556&path-prefix=pt', 19, N'Foco Rápido'),
(20, 1, N'O portador irá focar ALMA em um ritmo mais lento, mas o efeito de cura será dobrado.', N'https://static.wikia.nocookie.net/hollowknight/images/e/ea/Deep_Focus.png/revision/latest/scale-to-width-down/76?cb=20231011224730&path-prefix=pt', 20, N'Foco Profundo'),
(21, 1, N'Ao descansar, o portador irá ganhar uma camada de Sangue Vital que lhe protege de uma moderada quantidade de dano.', N'https://static.wikia.nocookie.net/hollowknight/images/7/7c/Lifeblood_Heart.png/revision/latest/scale-to-width-down/76?cb=20231011224903&path-prefix=pt', 21, N'Coração de Sangue Vital'),
(22, 1, N'Ao descansar, o portador irá ganhar uma camada de Sangue Vital que lhe protege de uma grande quantidade de dano.', N'https://static.wikia.nocookie.net/hollowknight/images/8/81/Lifeblood_Core.png/revision/latest/scale-to-width-down/76?cb=20231011225103&path-prefix=pt', 22, N'Núcleo de Sangue Vital'),
(23, 1, N'O portador terá uma carapaça mais saudável e poderá receber mais dano, porém ele será incapaz de curar se curar focando ALMA.', N'https://static.wikia.nocookie.net/hollowknight/images/6/67/Joni%27s_Blessing.png/revision/latest/scale-to-width-down/76?cb=20231011225246&path-prefix=pt', 23, N'Bênção de Joni'),
(24, 1, N'Recebe ALMA sempre que dano for recebido.', N'https://static.wikia.nocookie.net/hollowknight/images/7/78/Grubsong.png/revision/latest/scale-to-width-down/76?cb=20231011225502&path-prefix=pt', 24, N'Canção das Larvas'),
(25, 1, N'Infunde armas com uma energia sagrada. Quando o portador está com a vida cheia, ele lançará feixes de energia branca através de seu ferrão.', N'https://static.wikia.nocookie.net/hollowknight/images/b/bd/Grubberfly%27s_Elegy.png/revision/latest/scale-to-width-down/76?cb=20231011225628&path-prefix=pt', 25, N'Elegia da Larvamosca'),
(26, 1, N'Cura as feridas do portador ao longo do tempo, permitindo-o recuperar vida sem focar ALMA.', N'https://static.wikia.nocookie.net/hollowknight/images/e/eb/Hiveblood.png/revision/latest/scale-to-width-down/76?cb=20231011225751&path-prefix=pt', 26, N'Sangue da Colmeia'),
(27, 1, N'Quando Focando ALMA, emite uma nuvem de esporos que danifica lentamente os inimigos.', N'https://static.wikia.nocookie.net/hollowknight/images/7/78/Spore_Shroom.png/revision/latest/scale-to-width-down/76?cb=20231011230005&path-prefix=pt', 27, N'Cogumelo com Esporos'),
(28, 1, N'Ao se utilizar Esquiva Sombria, o corpo do portador se afiará e danificará inimigos.', N'https://static.wikia.nocookie.net/hollowknight/images/1/13/Sharp_Shadow.png/revision/latest/scale-to-width-down/76?cb=20231011230112&path-prefix=pt', 28, N'Sombra Afiada'),
(29, 1, N'Enquanto estiver focando ALMA, o portador irá assumir uma nova forma e pode mover-se livremente para evitar inimigos.', N'https://static.wikia.nocookie.net/hollowknight/images/b/b4/Shape_of_Unn.png/revision/latest/scale-to-width-down/76?cb=20231011230259&path-prefix=pt', 29, N'Forma de Unn'),
(30, 1, N'Aumenta a maestria do portador sob as Artes do Ferrão, permitindo-o focar seus poderes mais rapidamente, e os liberar mais cedo.', N'https://static.wikia.nocookie.net/hollowknight/images/0/0f/Nailmaster%27s_Glory.png/revision/latest/scale-to-width-down/76?cb=20231011230425&path-prefix=pt', 30, N'Glória do Mestre do Ferrão'),
(31, 1, N'Permite ao portador carregar o Ferrão dos Sonhos mais rapidamente e coletar mais ALMA atingindo inimigos.', N'https://static.wikia.nocookie.net/hollowknight/images/9/94/Dream_Wielder.png/revision/latest/scale-to-width-down/76?cb=20231011230608&path-prefix=pt', 31, N'Portador dos Sonhos'),
(32, 1, N'Amuleto sagrado simbolizando a união entre seres superiores. O portador irá lentamente absorver a ALMA ilimitada contida interiormente. Abre o caminho para o Local de Nascimento.', N'https://static.wikia.nocookie.net/hollowknight/images/3/34/Kingsoul.png/revision/latest/scale-to-width-down/76?cb=20231012001528&path-prefix=pt', 32, N'Alma do Rei'),
(33, 1, N'Um vazio escondido interiormente, agora sem restrições. Unifica o vazio sob a vontade do portador. Este amuleto é parte do portador e não pode ser desequipado.', N'https://static.wikia.nocookie.net/hollowknight/images/b/bb/Void_Heart.png/revision/latest/scale-to-width-down/76?cb=20231012001701&path-prefix=pt', 33, N'Coração Vazio'),
(34, 1, N'Conjura um escudo que segue o portador e tenta protegê-lo', N'https://static.wikia.nocookie.net/hollowknight/images/4/47/Dreamshield.png/revision/latest/scale-to-width-down/76?cb=20171102193106&path-prefix=pt', 34, N'Escudo dos Sonhos'),
(35, 1, N'Invoca pequenas tecelãs para dar ao portador solitário um pouco de companheirismo e proteção.', N'https://static.wikia.nocookie.net/hollowknight/images/2/26/Weaversong.png/revision/latest/scale-to-width-down/76?cb=20171102193112&path-prefix=pt', 35, N'Canção das Tecelãs'),
(36, 1, N'Usado por aqueles que participam do Ritual da Trupe Grimm. O portador deve buscar os Grimmários e coletar suas chamas. Chamas não coletadas aparecerão no mapa do portador.', N'https://static.wikia.nocookie.net/hollowknight/images/9/91/Grimmchild.png/revision/latest/scale-to-width-down/76?cb=20171102193127&path-prefix=pt', 36, N'Mestre da Corrida'),
(37, 1, N'Contém uma música de proteção que pode defender o portador de danos.', N'https://static.wikia.nocookie.net/hollowknight/images/c/c4/Carefree_Melody.png/revision/latest/scale-to-width-down/76?cb=20171102193135&path-prefix=pt', 37, N'Melodia Despreocupada'),
(38, 1, N'Aumenta a vida do portador.', N'https://static.wikia.nocookie.net/hollowknight/images/1/13/Fragile_Heart.png/revision/latest/scale-to-width-down/76?cb=20230804191026&path-prefix=pt', 38, N'Coração Frágil'),
(39, 1, N'Faz com que o portador encontre mais Geo ao derrotar inimigos.', N'https://static.wikia.nocookie.net/hollowknight/images/b/b6/Fragile_Greed.png/revision/latest/scale-to-width-down/76?cb=20231010030754&path-prefix=pt', 39, N'Ganância Frágil'),
(40, 1, N'Fortalece o portador, aumentando o dano causado aos inimigos com o ferrão.', N'https://static.wikia.nocookie.net/hollowknight/images/7/7b/Fragile_Strength.png/revision/latest/scale-to-width-down/76?cb=20231010224857&path-prefix=pt', 40, N'Força Frágil');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoriaItem', N'DescricaoItem', N'FotoItem', N'IdItem', N'NomeItem') AND [object_id] = OBJECT_ID(N'[TB_ITENS]'))
    SET IDENTITY_INSERT [TB_ITENS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231209211311_MigrationItens', N'7.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [TB_ITENS] DROP CONSTRAINT [FK_TB_ITENS_Personagem_PersonagemId];
GO

ALTER TABLE [TB_MOBS] DROP CONSTRAINT [FK_TB_MOBS_Personagem_PersonagemId];
GO

ALTER TABLE [Personagem] DROP CONSTRAINT [PK_Personagem];
GO

EXEC sp_rename N'[Personagem]', N'TB_PERSONAGENS';
GO

ALTER TABLE [TB_PERSONAGENS] ADD CONSTRAINT [PK_TB_PERSONAGENS] PRIMARY KEY ([Id]);
GO

ALTER TABLE [TB_ITENS] ADD CONSTRAINT [FK_TB_ITENS_TB_PERSONAGENS_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [TB_PERSONAGENS] ([Id]);
GO

ALTER TABLE [TB_MOBS] ADD CONSTRAINT [FK_TB_MOBS_TB_PERSONAGENS_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [TB_PERSONAGENS] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231209212857_MigrationPersonagens', N'7.0.4');
GO

COMMIT;
GO

