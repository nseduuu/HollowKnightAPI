using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HollowKnightAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigrationItens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ITENS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdItem = table.Column<int>(type: "int", nullable: false),
                    NomeItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaItem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ITENS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ITENS",
                columns: new[] { "Id", "CategoriaItem", "DescricaoItem", "FotoItem", "IdItem", "NomeItem" },
                values: new object[,]
                {
                    { 1, 1, "Sussura sua localização ao portador sempre que o mapa estiver aberto", "https://static.wikia.nocookie.net/hollowknight/images/7/7d/Wayward_Compass.png/revision/latest/scale-to-width-down/76?cb=20231011215858&path-prefix=pt", 1, "Bússula Caprichosa" },
                    { 2, 1, "Um enxame seguirá o portador e coletará quaisquer Geo deixado no chão.", "https://static.wikia.nocookie.net/hollowknight/images/8/8a/Gathering_Swarm.png/revision/latest/scale-to-width-down/76?cb=20231011220242&path-prefix=pt", 2, "Enxame de Colecionadores" },
                    { 3, 1, "Quando recuperando-se de dano recebido, o portador permanecerá invulnerável por mais tempo.", "https://static.wikia.nocookie.net/hollowknight/images/f/f2/Stalwart_Shell.png/revision/latest/scale-to-width-down/76?cb=20230731195337&path-prefix=pt", 3, "Carapaça Robusta" },
                    { 4, 1, "Aumenta a quantidade de ALMA recebida quando um oponente é atingido com o ferrão.", "https://static.wikia.nocookie.net/hollowknight/images/c/ca/Soul_Catcher.png/revision/latest/scale-to-width-down/76?cb=20231011220646&path-prefix=pt", 4, "Apanhador de Almas" },
                    { 5, 1, "Quando dano é recebido, brotam-se vinhas espinhentas que machucam inimigos próximos.", "https://static.wikia.nocookie.net/hollowknight/images/6/6c/Soul_Eater.png/revision/latest/scale-to-width-down/76?cb=20230731195650&path-prefix=pt", 5, "Pedra do Xamã" },
                    { 6, 1, "Aumenta consideravelmente a quantidade de ALMA recebida quando um oponente é atingido com o ferrão.", "https://static.wikia.nocookie.net/hollowknight/images/7/7d/Wayward_Compass.png/revision/latest/scale-to-width-down/76?cb=20231011215858&path-prefix=pt", 6, "Devorador de Almas" },
                    { 7, 1, "Permite que o portador esquive-se mais frequentemente assim como esquivar-se para baixo.", "https://static.wikia.nocookie.net/hollowknight/images/8/8f/Thorns_of_Agony.png/revision/latest/scale-to-width-down/76?cb=20230802200324&path-prefix=pt", 7, "Espinhos da Agonia" },
                    { 8, 1, "Quando próximo a morte, a força do portador irá aumentar.", "https://static.wikia.nocookie.net/hollowknight/images/4/4f/Fury_of_the_Fallen.png/revision/latest/scale-to-width-down/76?cb=20230802203206&path-prefix=pt", 8, "Fúria dos Caídos" },
                    { 9, 1, "Reduz o custo de ALMA para a canalização de magias", "https://static.wikia.nocookie.net/hollowknight/images/3/33/Spell_Twister.png/revision/latest/scale-to-width-down/76?cb=20231011212430&path-prefix=pt", 9, "Dobrador de Magias" },
                    { 10, 1, "Mantém seu portador firme, prevenindo-o de recuar quando atingir um inimigo com o Ferrão.", "https://static.wikia.nocookie.net/hollowknight/images/f/f5/Steady_Body.png/revision/latest/scale-to-width-down/76?cb=20231011221422&path-prefix=pt", 10, "Corpo Firme" },
                    { 11, 1, "Aumenta a força do ferrão do portador, causando inimigos a recuar mais quando atingidos.", "https://static.wikia.nocookie.net/hollowknight/images/f/f6/Heavy_Blow.png/revision/latest/scale-to-width-down/76?cb=20231011222923&path-prefix=pt", 11, "Golpe Pesado" },
                    { 12, 1, "Permite o portador cortar muito mais rapidamente com seu ferrão.", "https://static.wikia.nocookie.net/hollowknight/images/5/5f/Quick_Slash.png/revision/latest/scale-to-width-down/76?cb=20231011223343&path-prefix=pt", 12, "Corte Rápido" },
                    { 13, 1, "Aumenta o alcance do ferrão do portador.", "https://static.wikia.nocookie.net/hollowknight/images/d/d1/Longnail.png/revision/latest/scale-to-width-down/76?cb=20231011223530&path-prefix=pt", 13, "Ferrão Longo" },
                    { 14, 1, "Aumenta consideravelmente o alcance do ferrão do portador.", "https://static.wikia.nocookie.net/hollowknight/images/6/69/Mark_of_Pride.png/revision/latest/scale-to-width-down/76?cb=20231011223649&path-prefix=pt", 14, "Marca de Orgulho" },
                    { 15, 1, "Protege o portador com uma carapaça dura enquanto estiver focando ALMA.", "https://static.wikia.nocookie.net/hollowknight/images/2/21/Baldur_Shell.png/revision/latest/scale-to-width-down/76?cb=20231011223844&path-prefix=pt", 15, "Carapaça de Baldur" },
                    { 16, 1, "Transforma a magia Espirito Vingativo em uma horda de voláteis flukes bebês.", "https://static.wikia.nocookie.net/hollowknight/images/7/7d/Wayward_Compass.png/revision/latest/scale-to-width-down/76?cb=20231011215858&path-prefix=pt", 16, "Ninho de Flukes" },
                    { 17, 1, "Causa o portador a emitir um odor heróico.", "https://static.wikia.nocookie.net/hollowknight/images/5/56/Defender%27s_Crest.png/revision/latest/scale-to-width-down/76?cb=20231011224240&path-prefix=pt", 17, "Insignia do Defensor" },
                    { 18, 1, "Drena a ALMA de seu portador e utiliza-a para parir crias.", "https://static.wikia.nocookie.net/hollowknight/images/c/c6/Glowing_Womb.png/revision/latest/scale-to-width-down/76?cb=20231011224432&path-prefix=pt", 18, "Útero Brilhante" },
                    { 19, 1, "Aumenta a velocidade do foco da ALMA, permitindo que o portador se cure mais rapidamente.", "https://static.wikia.nocookie.net/hollowknight/images/6/6a/Quick_Focus.png/revision/latest/scale-to-width-down/76?cb=20231011224556&path-prefix=pt", 19, "Foco Rápido" },
                    { 20, 1, "O portador irá focar ALMA em um ritmo mais lento, mas o efeito de cura será dobrado.", "https://static.wikia.nocookie.net/hollowknight/images/e/ea/Deep_Focus.png/revision/latest/scale-to-width-down/76?cb=20231011224730&path-prefix=pt", 20, "Foco Profundo" },
                    { 21, 1, "Ao descansar, o portador irá ganhar uma camada de Sangue Vital que lhe protege de uma moderada quantidade de dano.", "https://static.wikia.nocookie.net/hollowknight/images/7/7c/Lifeblood_Heart.png/revision/latest/scale-to-width-down/76?cb=20231011224903&path-prefix=pt", 21, "Coração de Sangue Vital" },
                    { 22, 1, "Ao descansar, o portador irá ganhar uma camada de Sangue Vital que lhe protege de uma grande quantidade de dano.", "https://static.wikia.nocookie.net/hollowknight/images/8/81/Lifeblood_Core.png/revision/latest/scale-to-width-down/76?cb=20231011225103&path-prefix=pt", 22, "Núcleo de Sangue Vital" },
                    { 23, 1, "O portador terá uma carapaça mais saudável e poderá receber mais dano, porém ele será incapaz de curar se curar focando ALMA.", "https://static.wikia.nocookie.net/hollowknight/images/6/67/Joni%27s_Blessing.png/revision/latest/scale-to-width-down/76?cb=20231011225246&path-prefix=pt", 23, "Bênção de Joni" },
                    { 24, 1, "Recebe ALMA sempre que dano for recebido.", "https://static.wikia.nocookie.net/hollowknight/images/7/78/Grubsong.png/revision/latest/scale-to-width-down/76?cb=20231011225502&path-prefix=pt", 24, "Canção das Larvas" },
                    { 25, 1, "Infunde armas com uma energia sagrada. Quando o portador está com a vida cheia, ele lançará feixes de energia branca através de seu ferrão.", "https://static.wikia.nocookie.net/hollowknight/images/b/bd/Grubberfly%27s_Elegy.png/revision/latest/scale-to-width-down/76?cb=20231011225628&path-prefix=pt", 25, "Elegia da Larvamosca" },
                    { 26, 1, "Cura as feridas do portador ao longo do tempo, permitindo-o recuperar vida sem focar ALMA.", "https://static.wikia.nocookie.net/hollowknight/images/e/eb/Hiveblood.png/revision/latest/scale-to-width-down/76?cb=20231011225751&path-prefix=pt", 26, "Sangue da Colmeia" },
                    { 27, 1, "Quando Focando ALMA, emite uma nuvem de esporos que danifica lentamente os inimigos.", "https://static.wikia.nocookie.net/hollowknight/images/7/78/Spore_Shroom.png/revision/latest/scale-to-width-down/76?cb=20231011230005&path-prefix=pt", 27, "Cogumelo com Esporos" },
                    { 28, 1, "Ao se utilizar Esquiva Sombria, o corpo do portador se afiará e danificará inimigos.", "https://static.wikia.nocookie.net/hollowknight/images/1/13/Sharp_Shadow.png/revision/latest/scale-to-width-down/76?cb=20231011230112&path-prefix=pt", 28, "Sombra Afiada" },
                    { 29, 1, "Enquanto estiver focando ALMA, o portador irá assumir uma nova forma e pode mover-se livremente para evitar inimigos.", "https://static.wikia.nocookie.net/hollowknight/images/b/b4/Shape_of_Unn.png/revision/latest/scale-to-width-down/76?cb=20231011230259&path-prefix=pt", 29, "Forma de Unn" },
                    { 30, 1, "Aumenta a maestria do portador sob as Artes do Ferrão, permitindo-o focar seus poderes mais rapidamente, e os liberar mais cedo.", "https://static.wikia.nocookie.net/hollowknight/images/0/0f/Nailmaster%27s_Glory.png/revision/latest/scale-to-width-down/76?cb=20231011230425&path-prefix=pt", 30, "Glória do Mestre do Ferrão" },
                    { 31, 1, "Permite ao portador carregar o Ferrão dos Sonhos mais rapidamente e coletar mais ALMA atingindo inimigos.", "https://static.wikia.nocookie.net/hollowknight/images/9/94/Dream_Wielder.png/revision/latest/scale-to-width-down/76?cb=20231011230608&path-prefix=pt", 31, "Portador dos Sonhos" },
                    { 32, 1, "Amuleto sagrado simbolizando a união entre seres superiores. O portador irá lentamente absorver a ALMA ilimitada contida interiormente. Abre o caminho para o Local de Nascimento.", "https://static.wikia.nocookie.net/hollowknight/images/3/34/Kingsoul.png/revision/latest/scale-to-width-down/76?cb=20231012001528&path-prefix=pt", 32, "Alma do Rei" },
                    { 33, 1, "Um vazio escondido interiormente, agora sem restrições. Unifica o vazio sob a vontade do portador. Este amuleto é parte do portador e não pode ser desequipado.", "https://static.wikia.nocookie.net/hollowknight/images/b/bb/Void_Heart.png/revision/latest/scale-to-width-down/76?cb=20231012001701&path-prefix=pt", 33, "Coração Vazio" },
                    { 34, 1, "Conjura um escudo que segue o portador e tenta protegê-lo", "https://static.wikia.nocookie.net/hollowknight/images/4/47/Dreamshield.png/revision/latest/scale-to-width-down/76?cb=20171102193106&path-prefix=pt", 34, "Escudo dos Sonhos" },
                    { 35, 1, "Invoca pequenas tecelãs para dar ao portador solitário um pouco de companheirismo e proteção.", "https://static.wikia.nocookie.net/hollowknight/images/2/26/Weaversong.png/revision/latest/scale-to-width-down/76?cb=20171102193112&path-prefix=pt", 35, "Canção das Tecelãs" },
                    { 36, 1, "Usado por aqueles que participam do Ritual da Trupe Grimm. O portador deve buscar os Grimmários e coletar suas chamas. Chamas não coletadas aparecerão no mapa do portador.", "https://static.wikia.nocookie.net/hollowknight/images/9/91/Grimmchild.png/revision/latest/scale-to-width-down/76?cb=20171102193127&path-prefix=pt", 36, "Mestre da Corrida" },
                    { 37, 1, "Contém uma música de proteção que pode defender o portador de danos.", "https://static.wikia.nocookie.net/hollowknight/images/c/c4/Carefree_Melody.png/revision/latest/scale-to-width-down/76?cb=20171102193135&path-prefix=pt", 37, "Melodia Despreocupada" },
                    { 38, 1, "Aumenta a vida do portador.", "https://static.wikia.nocookie.net/hollowknight/images/1/13/Fragile_Heart.png/revision/latest/scale-to-width-down/76?cb=20230804191026&path-prefix=pt", 38, "Coração Frágil" },
                    { 39, 1, "Faz com que o portador encontre mais Geo ao derrotar inimigos.", "https://static.wikia.nocookie.net/hollowknight/images/b/b6/Fragile_Greed.png/revision/latest/scale-to-width-down/76?cb=20231010030754&path-prefix=pt", 39, "Ganância Frágil" },
                    { 40, 1, "Fortalece o portador, aumentando o dano causado aos inimigos com o ferrão.", "https://static.wikia.nocookie.net/hollowknight/images/7/7b/Fragile_Strength.png/revision/latest/scale-to-width-down/76?cb=20231010224857&path-prefix=pt", 40, "Força Frágil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ITENS");
        }
    }
}
