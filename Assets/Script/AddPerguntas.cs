using System.Collections.Generic;

/* 
 *   Autor/Author: Pedro Lucas de Oliveira Cabral 
 *   GitHub: https://github.com/DoisLucas
 *   Data/Date: 01/02/2018
 */

public class AddPerguntas
{

    public static List<Perguntas> perguntas_exatas = new List<Perguntas>();
    public static List<Perguntas> perguntas_humanas = new List<Perguntas>();
    public static List<Perguntas> perguntas_bio = new List<Perguntas>();

    public static List<Perguntas> getPerguntas_all()
    {
        List<Perguntas> all = new List<Perguntas>();

        for (int i = 0; i < perguntas_exatas.Count; i++)
        {
            all.Add(perguntas_exatas[i]);
        }

        for (int i = 0; i < perguntas_humanas.Count; i++)
        {
            all.Add(perguntas_humanas[i]);
        }

        for (int i = 0; i < perguntas_bio.Count; i++)
        {
            all.Add(perguntas_bio[i]);
        }

        return all;
    }

    public static void Add_All()
    {
        Add_exatas();
        Add_humanas();
        Add_bio();
    }

    public static List<Perguntas> getPerguntas_exatas()
    {
        return perguntas_exatas;
    }

    public static List<Perguntas> getPerguntas_humanas()
    {
        return perguntas_humanas;
    }

    public static List<Perguntas> getPerguntas_bio()
    {
        return perguntas_bio;
    }

    public static void Add_humanas()
    {
        if (perguntas_humanas.Count == 0)
        {
            Perguntas p1 = new Perguntas("Quantos estados o Brasil possui?", 4, "32", "24", "23", "26", 5);
            perguntas_humanas.Add(p1);

            Perguntas p2 = new Perguntas("Qual foi a primeira capital do Brasil?", 1, "Salvador", "Rio de Janeiro", "Brasilia", "Sergipe", 5);
            perguntas_humanas.Add(p2);

            Perguntas p3 = new Perguntas("Em que ano a 2ª guerra mundial acabou?", 2, "1939", "1945", "1946", "1950", 5);
            perguntas_humanas.Add(p3);

            Perguntas p4 = new Perguntas("Em que ano iniciou-se a 2ª guerra mundial?", 3, "1946", "1945", "1939", "1950", 5);
            perguntas_humanas.Add(p4);

            Perguntas p5 = new Perguntas("Onde ocorreu à revolta da chibata?", 4, "Bahia", "Pernambuco", "Maranhão", "Rio de Janeiro", 5);
            perguntas_humanas.Add(p5);

            Perguntas p6 = new Perguntas("Onde ocorreu à revolta da balaiada?", 1, "Maranhão", "Pernambuco", "Alagoas", "Rio de Janeiro", 5);
            perguntas_humanas.Add(p6);

            Perguntas p7 = new Perguntas("Qual presidente americano foi assassinado em um carro aberto por um atirador?", 2, "George W. Bush", "John F. Kennedy", "Thomas Jefferson", "Abraham Lincoln", 5);
            perguntas_humanas.Add(p7);

            Perguntas p8 = new Perguntas("Qual foi o estopim da Segunda Guerra?", 3, "Invasão da Renânia", "Invasão da União Soviética", "Invasão da Polônia", "Invasão da França", 5);
            perguntas_humanas.Add(p8);

            Perguntas p9 = new Perguntas("Qual o nome dado à invasão da Normandia?", 1, "Dia A", "Dia B", "Dia C", "Dia E", 10);
            perguntas_humanas.Add(p9);

            Perguntas p10 = new Perguntas("Qual foi o presidente que deu o Golpe do Estado Novo?", 2, "José Linhares", "Getúlio Vargas", "João Goulart", "Café Filho", 5);
            perguntas_humanas.Add(p10);

            Perguntas p11 = new Perguntas("A Guerra Fria aconteceu durante quais anos?", 2, "1944 - 1989", "1947 - 1991", "1949 - 1996", "1949 - 1996", 5);
            perguntas_humanas.Add(p11);

            Perguntas p12 = new Perguntas("Qual das alternativas abaixo aponta uma das principais invençôes que foi fundamental para a Revoluçaõ Industrial?", 4, "Telefone", "Telégrafo", "Calculadora manual", "Máquina a vapor", 5);
            perguntas_humanas.Add(p12);

            Perguntas p13 = new Perguntas("A globalização só foi possível pelo fato de ter ocorrido a(s) o(s)?", 2, "1ª Guerra Mundial", "Revoluções Industriais", "Iluminismo", "Revolução Russa", 5);
            perguntas_humanas.Add(p13);

            Perguntas p14 = new Perguntas("Qual o país com a maior concentração de vulcões?", 2, "Chile", "Indonésia", "Croácia", "Havaí", 5);
            perguntas_humanas.Add(p14);

            Perguntas p15 = new Perguntas("Que tipo de rocha é encontrado em um vulcão?", 2, "Ígnea", "Sedimentar", "Metamórfica", "Plutônica", 10);
            perguntas_humanas.Add(p15);

            Perguntas p16 = new Perguntas("A agricultura moderna tem causado diversos impactos ambientais. Dentre eles podemos citar:", 3, "Aquecimento global", "Efeito estufa", "A erosão do solo", "Poluição do ar", 5);
            perguntas_humanas.Add(p16);

            Perguntas p17 = new Perguntas("O que significa a sigla IDH?", 4, "Índice de Desenvolvimento do Homem", "Índice de Desenvolvimento hispânico", "Índice de Desenvoltura Humana", "Índice de Desenvolvimento Humano", 5);
            perguntas_humanas.Add(p17);

            Perguntas p18 = new Perguntas("Qual a lingua mais falada no mundo?", 2, "Inglês", "Mandarim", "Espanhol", "Francês", 5);
            perguntas_humanas.Add(p18);

            Perguntas p19 = new Perguntas("Quem escreveu o livro Dom Casmurro?", 3, "José de Alencar", "Lima Barreto", "Machado de Assis", "Euclides da Cunha", 5);
            perguntas_humanas.Add(p19);

            Perguntas p20 = new Perguntas("Quem escreveu o livro Macunaíma?", 2, "Oswald de Andrade", "Mário de Andrade", "Monteiro Lobato", "Carlos Drummond de Andrade", 5);
            perguntas_humanas.Add(p20);

            Perguntas p21 = new Perguntas("Quem escreveu o livro O Guarani?", 3, "Gonçalves de Magalhães", "Castro Alves", "José de Alencar", "Gonçalves Dias", 5);
            perguntas_humanas.Add(p21);

            Perguntas p22 = new Perguntas("A escultura barroca se destaca por vários aspectos. Assinale o item incorreto sobre a escultura barroca.", 2, "Drapeados", "Uso da razão", "Linha curvas", "Dramaticidade", 10);
            perguntas_humanas.Add(p22);

            Perguntas p23 = new Perguntas("Quem pintou o quadro Juízo Final?", 1, "Caravaggio", "Michelangelo", "Monet", "Manet", 10);
            perguntas_humanas.Add(p23);

            Perguntas p24 = new Perguntas("A arte barroca foi uma arte em oposição a(o):", 2, "Arte gótica", "Renascimento Cultural", "Classismo", "Neoclassismo", 10);
            perguntas_humanas.Add(p24);

            Perguntas p25 = new Perguntas("Hoje, fui ao supermercado comprar um leite para o café da manhã. Qual figura de linguagem presente na frase?", 4, "Metáfora", "Metonímia", "Perífrase", "Elipses", 10);
            perguntas_humanas.Add(p25);

            Perguntas p26 = new Perguntas("Figura de linguagem expressa na frase: Ela quase desmaiou ao ver a hora do seu relógio de pulso", 1, "Hipérbole", "Metáfora", "Gradação", "Paradoxo", 5);
            perguntas_humanas.Add(p26);

            Perguntas p27 = new Perguntas("O plural de 'qualquer cidadão' é:", 4, "Qualquer - Cidadãos", "Quaisquer - Cidadões", "Quaisquer - Cidadães", "Qualquer - Cidadões", 5);
            perguntas_humanas.Add(p27);

            Perguntas p28 = new Perguntas("Quantas letras tem o alfabeto atual?", 2, "25", "26", "29", "30", 10);
            perguntas_humanas.Add(p28);

            Perguntas p29 = new Perguntas("Qual das opções a seguir é a correta gramaticalmente?", 3, "Centopéa", "Sentopeia", "Centopéia", "Cemtopeia", 5);
            perguntas_humanas.Add(p29);

            Perguntas p30 = new Perguntas("A tomada do poder por Vargas e o consequente fim da República Oligárquica é geralmente denominada:", 3, "Golpe do Estado Novo", "Revolução Constitucionalista", "Revolução de 30", "Varguismo", 5);
            perguntas_humanas.Add(p30);

            Perguntas p31 = new Perguntas("A Consolidação das Leis Trabalhistas foi um marco da Era Vargas que ocorreu durante:", 4, "O Governo Provisório", "O Governo Constitucional", "O Governo Definitivo", "O Estado Novo", 5);
            perguntas_humanas.Add(p31);

            Perguntas p32 = new Perguntas("Em que ano iniciou-se a Revolução Francesa?", 4, "1788", "1769", "1799", "1789", 10);
            perguntas_humanas.Add(p32);

            Perguntas p33 = new Perguntas("O Brasil faz parte de qual ou quais bloco(s) econômico(s)?", 4, "Comunidade Andina", "CEI", "Mercosul e Nafta", "Mercosul", 5);
            perguntas_humanas.Add(p33);

            Perguntas p34 = new Perguntas("Qual o nome do oceano situado no extremo norte do planeta?", 2, "Oceano Índico", "Oceano Glacial Ártico", "Oceano Glacial Ártico", "Oceano Pacífico", 10);
            perguntas_humanas.Add(p34);

            Perguntas p35 = new Perguntas("Qual é o mar mais salgado da superfície terrestre?", 4, "Mar do Japão", "Golfo Pérsico", "Mar Negro", "Mar Vermelho", 5);
            perguntas_humanas.Add(p35);

            Perguntas p36 = new Perguntas("Qual é o maior mar da superfície terrestre?", 1, "Mar da China", "Mar do Caribe", "Mar de Coral", "Mar de Bering", 10);
            perguntas_humanas.Add(p36);

            Perguntas p37 = new Perguntas("Em que ano o estado novo chegou ao fim junto ao governo Vargas?", 1, "1945", "1944", "1941", "1937", 10);
            perguntas_humanas.Add(p37);

            Perguntas p38 = new Perguntas("Durante a Primeira República Brasileira, qual foi o primeiro presidente eleito de forma direta?", 2, "Floriano Peixoto", "Prudente de Morais", "Nilo Peçanha", "João Goulart", 10);
            perguntas_humanas.Add(p38);

            Perguntas p39 = new Perguntas("Eleita a primeira presidente mulher do Brasil, Dilma Rousseff começou seu mandato em 1º de janeiro de:", 2, "2010", "2011", "2012", "2009", 5);
            perguntas_humanas.Add(p39);

            Perguntas p40 = new Perguntas("A qual destes movimentos pertence o livro Macunaíma?", 3, "2ª Fase do Romantismo", "Realismo", "Modernismo", "Naturalismo", 5);
            perguntas_humanas.Add(p40);

            Perguntas p41 = new Perguntas("Qual o clima que mais abrange espaço no Brasil?", 4, "Tropical úmido", "Semi-árido", "Subtropical", "Tropical de savanas", 5);
            perguntas_humanas.Add(p41);

            Perguntas p42 = new Perguntas("Qual o estado brasileiro com o maior litoral?", 1, "Bahia", "Rio Grande do Sul", "Rio de Janeiro", "São Paulo", 5);
            perguntas_humanas.Add(p42);

            Perguntas p43 = new Perguntas("Na frase 'Bom dia!' Qual é o tipo de sujeito?", 3, "Sujeito Simples", "Sujeito Composto", "Sujeito Inexistente", "Sujeito Oculto", 5);
            perguntas_humanas.Add(p43);

            Perguntas p44 = new Perguntas("Qual das alternativas não é uma conjunção?", 1, "Nunca", "Porém", "Porque", "Nem", 5);
            perguntas_humanas.Add(p44);

            Perguntas p45 = new Perguntas("Vanguarda europeia que foi definida como anti-arte?", 3, "Expressionismo", "Impressionismo", "Dadaísmo", "Concretismo", 10);
            perguntas_humanas.Add(p45);

            Perguntas p46 = new Perguntas("Quem foi o precursor do movimento Concretista no Brasil?", 3, "Helio Oticida", "Anita Malfatti", "Max Bill", "Caetano Veloso", 10);
            perguntas_humanas.Add(p46);

            Perguntas p47 = new Perguntas("Em que ano foi realizada a Semana de Arte Moderna em São Paulo?", 1, "1922", "1912", "1945", "1992", 5);
            perguntas_humanas.Add(p47);

            Perguntas p48 = new Perguntas("Podemos dizer que, além do Barroco, outro movimento artístico introduzido pelos portugueses no Brasil é o:", 1, "Neoclássico", "Simbolista", "Expressionista", "Contemporâneo", 10);
            perguntas_humanas.Add(p48);

            Perguntas p49 = new Perguntas("Qual foi o primeiro movimento artístico que na pintura teve grandes e reais contrastes de luz e sombra, tendo como cenas temas religiosos e cotidianos?", 2, "Renascimento", "Barroco", "Neoclassicismo", "Neoclassicismo", 5);
            perguntas_humanas.Add(p49);

            Perguntas p50 = new Perguntas("Qual alternativa está escrita corretamente?", 1, "Com certeza", "Concerteza", "Concertesa", "Conserteza", 5);
            perguntas_humanas.Add(p50);
        }
    }

    public static void Add_bio()
    {
        if (perguntas_bio.Count == 0)
        {
            Perguntas p1 = new Perguntas("Qual das alternativas abaixo é uma doença causada por um protozoário?", 1, "Malária", "Sapinho", "Sarampo", "Micoses", 5);
            perguntas_bio.Add(p1);

            Perguntas p2 = new Perguntas("Quem faz parte do reino protista?", 3, "Algas e fungos", "Protozoários e fungos", "Algas e protozoários", "Algas e bactérias", 5);
            perguntas_bio.Add(p2);

            Perguntas p3 = new Perguntas("Qual a organela responsável pela digestão intracelular?", 2, "Ribossomos", "Lisossomo", "Mitocôndrias", "Centriolos", 5);
            perguntas_bio.Add(p3);

            Perguntas p4 = new Perguntas("Qual a única organela que uma bactéria possui?", 1, "Ribossomos", "Lisossomo", "Cromatina", "Núcleo", 5);
            perguntas_bio.Add(p4);

            Perguntas p5 = new Perguntas("A membrana é formada:", 1, "Fosfolipídica e proteínas", "Fósforo e proteínas", "Glicídios e proteínas", "Proteínas", 5);
            perguntas_bio.Add(p5);

            Perguntas p6 = new Perguntas("O ATP está relacionado a:", 1, "Produção de energia", "Energia luminosa", "Reprodução assexuada", "Fotossíntese", 5);
            perguntas_bio.Add(p6);

            Perguntas p7 = new Perguntas("Mitocôndrias está relacionado a:", 2, "Síntese de proteínas", "Energia", "Fotossíntese", "Digestão intra-celular", 5);
            perguntas_bio.Add(p7);

            Perguntas p8 = new Perguntas("Considerando o coração de um mamífero, qual das quatro cavidades apresenta parede mais espessa?", 4, "Artéria aorta", "Ventrículo direito", "Átrio direito", "Ventrículo esquerdo", 5);
            perguntas_bio.Add(p8);

            Perguntas p9 = new Perguntas("Qual cor de cabelo é um exemplo de mutação?", 2, "Loiro", "Ruivo", "Preto", "Castanho", 5);
            perguntas_bio.Add(p9);

            Perguntas p10 = new Perguntas("Qual dessas substâncias é fundamental para que ocorra a 'queima' de glicídios nos humanos e animais?", 3, "Gás carbônico", "Nitrogênio", "Oxigênio", "Água (H2O)", 5);
            perguntas_bio.Add(p10);

            Perguntas p11 = new Perguntas("O que é causa a doença raiva?", 1, "Um vírus", "Uma bactéria", "Um fungo", "Um protozoário", 5);
            perguntas_bio.Add(p11);

            Perguntas p12 = new Perguntas("Quais são as principais substâncias que formam a membrana plasmática nos humanos?", 3, "Proteínas e glicose", "Aminoácidos e gliceraldeídos", "Fosfolipídios e proteínas", "Fibrina e colágeno", 5);
            perguntas_bio.Add(p12);

            Perguntas p13 = new Perguntas("Quantos cromossomos espera-se encontrar em um espermatozoide pertencente a um humano normal?", 2, "45", "23", "28", "32", 5);
            perguntas_bio.Add(p13);

            Perguntas p14 = new Perguntas("Na escala evolutiva dos animais, os organismos cujo organismo é o mais simples são as:", 3, "Minhocas", "Águas-vivas", "Esponjas", "Anêmonas", 5);
            perguntas_bio.Add(p14);

            Perguntas p15 = new Perguntas("Qual a ciência que estuda a estrutura e as funções das células?", 3, "Histologia", "Taxonomia", "Citologia", "Fisiologia", 5);
            perguntas_bio.Add(p15);

            Perguntas p16 = new Perguntas("Qual é o reino que possui maior variedade de espécies?", 2, "Protista", "Monera", "Fungi", "Plantae", 10);
            perguntas_bio.Add(p16);

            Perguntas p17 = new Perguntas("Qual é a símbolo do titânio?", 1, "Ti", "Tt", "To", "Tn", 5);
            perguntas_bio.Add(p17);

            Perguntas p18 = new Perguntas("Qual é a classificação do hélio?", 3, "Semi-metal", "Metal alcalino", "Gás nobre", "Halogênio", 5);
            perguntas_bio.Add(p18);

            Perguntas p19 = new Perguntas("Quem criou (organizou) a tabela periódica?", 3, "Isaac Newton", "Lavoisier", "Mendeleev", "Marie Curie", 5);
            perguntas_bio.Add(p19);

            Perguntas p20 = new Perguntas("Quem é conhecido como o 'Pai da química'?", 1, "Lavoisier", "Marie Curie", "Robespierre", "Mendeleev", 5);
            perguntas_bio.Add(p20);

            Perguntas p21 = new Perguntas("Qual é a símbolo do Ouro?", 1, "Au", "Ou", "Or", "Ag", 5);
            perguntas_bio.Add(p21);

            Perguntas p22 = new Perguntas("O que é NaCl?", 2, "Hipoclorito de Sódio", "Cloreto de Sódio", "Ácido Perclórico", "Ácido Carbônico", 5);
            perguntas_bio.Add(p22);

            Perguntas p23 = new Perguntas("O número atômico do ouro é:", 4, "49", "59", "69", "79", 10);
            perguntas_bio.Add(p23);

            Perguntas p24 = new Perguntas("Qual a função orgânica utilizada para dar sabor aos alimentos?", 3, "Enol", "Fenol", "Éster", "Éter", 5);
            perguntas_bio.Add(p24);

            Perguntas p25 = new Perguntas("Quantos átomos estão presentes na fórmula da água?", 4, "5 Átomo", "2 Átomo", "1 Átomo", "3 Átomo", 5);
            perguntas_bio.Add(p25);

            Perguntas p26 = new Perguntas("Que símbolo significa numero atômico?", 1, "Z", "X", "Y", "N", 5);
            perguntas_bio.Add(p26);

            Perguntas p27 = new Perguntas("Como se chama os átomos que tem o mesmo número de neutros", 3, "Isoeletrônicos", "Isóbaros", "Isótonos", "Isótopos", 5);
            perguntas_bio.Add(p27);

            Perguntas p28 = new Perguntas("Como se chama o íon com carga positiva?", 2, "Ânion", "Cation", "Cution", "Cerion", 5);
            perguntas_bio.Add(p28);

            Perguntas p29 = new Perguntas("Como se chama a passagem do estado solido para o gasoso?", 3, "Fusão", "Ebulição", "Sublimação", "Solidificação", 5);
            perguntas_bio.Add(p29);

            Perguntas p30 = new Perguntas("Há quantos estados físicos na química?", 1, "3", "2", "1", "4", 5);
            perguntas_bio.Add(p30);

            Perguntas p31 = new Perguntas("A Maconha é uma planta herbácea de clima quente, podendo atingir até 5 metros de altura. Essa planta é originária de qual país?", 4, "Paraguai", "Uruguai", "Jamaica", "Índia", 5);
            perguntas_bio.Add(p31);

            Perguntas p32 = new Perguntas("Qual é o menor ser vivo conhecido atualmente?", 4, "Vírus", "Ameba", "Giárdia", "Bactéria", 5);
            perguntas_bio.Add(p32);

            Perguntas p33 = new Perguntas("Qual é a composição química dos alimentos?", 4, "CH", "CHON", "CHO", "CHONS", 10);
            perguntas_bio.Add(p33);

            Perguntas p34 = new Perguntas("O sangue é vermelho devido a presença de que composto?", 3, "Troponina", "Albumina", "Hemoglobina", "Fibrina", 5);
            perguntas_bio.Add(p34);

            Perguntas p35 = new Perguntas("Como são chamados os animais que se alimentam de vários alimentos como ervas, carnes, e outros alimentos?", 3, "Carnívoros", "Herbívoros", "Onívoros", "Aquíferos", 5);
            perguntas_bio.Add(p35);

            Perguntas p36 = new Perguntas("O tecido conjuntivo que envolve os músculos e que continua para os tendões designa-se:", 3, "Perimísio", "Endomísio", "Epimísio", "Sarcolema", 10);
            perguntas_bio.Add(p36);

            Perguntas p37 = new Perguntas("Qual significado de DNA?", 2, "Ácido Ribonucleico", "Ácido Dexorribonucleíco", "Base Adenina Nitrogenada", "Purina Ácido Pirimidina", 10);
            perguntas_bio.Add(p37);

            Perguntas p38 = new Perguntas("Do que é constituido o DNA?", 1, "Nucleotídeos", "RNA", "Carbono", "Moléculas de H2O", 10);
            perguntas_bio.Add(p38);

            Perguntas p39 = new Perguntas("Em que parte da célula o RNA realiza a função de sintetizar proteínas?", 1, "No núcleo", "No citoplasma", "No genoma", "Na dupla hélice", 10);
            perguntas_bio.Add(p39);

            Perguntas p40 = new Perguntas("Quantos elétrons a camada 'O' pode guardar?", 1, "2 Elétrons", "8 Elétrons", "18 Elétrons", "32 Elétrons", 10);
            perguntas_bio.Add(p40);

            Perguntas p41 = new Perguntas("Em quantos grupos podemos classificar os ácidos?", 1, "1", "2", "3", "4", 5);
            perguntas_bio.Add(p41);

            Perguntas p42 = new Perguntas("Qual é o ácido mais forte conhecido até hoje?", 1, "Ácido Nítrico", "Ácido Sulfúrico", "Ácido Clorídrico", "Ácido Sulfídrico", 10);
            perguntas_bio.Add(p42);

            Perguntas p43 = new Perguntas("Quantos grupos tem a tabela periódica?", 3, "17", "13", "18", "20", 10);
            perguntas_bio.Add(p43);

            Perguntas p44 = new Perguntas("Quantos periodos constituem a tabela periódica?", 2, "11", "7", "10", "9", 10);
            perguntas_bio.Add(p44);

            Perguntas p45 = new Perguntas("Qual destes elementos é um alcalino-terroso?", 3, "Sódio", "Potássio", "Cálcio", "Rubidio", 10);
            perguntas_bio.Add(p45);

            Perguntas p46 = new Perguntas("Qual o elemento quimico com menos elétrons?", 4, "Oxigênio", "Hélio", "Ferro", "Hidrogénio", 5);
            perguntas_bio.Add(p46);

            Perguntas p47 = new Perguntas("Qual é o número atômico do Carbono?", 4, "2", "8", "4", "6", 5);
            perguntas_bio.Add(p47);

            Perguntas p48 = new Perguntas("No corpo humano, onde se armazena o glicogênio?", 3, "Tecido adiposo e fígado", "Músculos e tecido adiposo", "Fígado e Músculos", "Estômago e Fígado", 5);
            perguntas_bio.Add(p48);

            Perguntas p49 = new Perguntas("Qual substância é feita de bactérias ou vírus vivos mas em ação atenuada ?", 2, "Soro", "Vacina", "Veneno", "Anticorpos", 5);
            perguntas_bio.Add(p49);

            Perguntas p50 = new Perguntas("Em qual cromossomo há a alteração que resulta na Síndrome de Down?", 3, "6", "18", "21", "15", 10);
            perguntas_bio.Add(p50);
        }
    }

    public static void Add_exatas()
    {
        if (perguntas_exatas.Count == 0)
        {
            Perguntas p1 = new Perguntas("Qual teorema é utilizado para calcular o módulo de um número complexo?", 1, "Teorema de Pitágoras", "Teorema do Resto", "Teorema de Euler", "Teorema de Pascal", 10);
            perguntas_exatas.Add(p1);

            Perguntas p2 = new Perguntas("A área do circulo é:", 3, "A = 2.π.r", "A = π.r / 2", "A = π.r²", "A = d.r²", 5);
            perguntas_exatas.Add(p2);

            Perguntas p3 = new Perguntas("A área do retângulo é:", 1, "A = base.altura", "A = base / altura", "A = altura / base", "A = (base.altura) / 2", 5);
            perguntas_exatas.Add(p3);

            Perguntas p4 = new Perguntas("A área do quadrado é:", 3, "A = lado.diagonal", "A = lado / diagonal", "A = lado.lado", "A = diagonal.diagonal", 5);
            perguntas_exatas.Add(p4);

            Perguntas p5 = new Perguntas("A área do losangulo é:", 4, "A = D.d", "A = 2.D / d", "A = (D + d) / 2", "A = (D.d) / 2", 5);
            perguntas_exatas.Add(p5);

            Perguntas p6 = new Perguntas("A área do Triângulo equilátero é:", 3, "A = lado.lado", "A = 4.(lado . lado) / 3 ", "A = 3.(lado . lado) / 4", "A = 3.(lado + lado) / 4", 5);
            perguntas_exatas.Add(p6);

            Perguntas p7 = new Perguntas("A área do Triângulo é:", 2, "A = base.altura", "A = (base.altura) / 2", "A = (2.base) / altura", "A = base + (altura / 2)", 5);
            perguntas_exatas.Add(p7);

            Perguntas p8 = new Perguntas("A área do Trapézio é: ", 3, "A = (B + b) . h", "A = (B + b) / 2", "A = (B + b) . h / 2", "A = 2.(B + b) / 2", 5);
            perguntas_exatas.Add(p8);

            Perguntas p9 = new Perguntas("A área da Esfera é:", 1, "A = 4.π.r²", "A = 2.π.r²", "A = 4.π.r³", "A = π.r³", 5);
            perguntas_exatas.Add(p9);

            Perguntas p10 = new Perguntas("A área do setor circular é: (ABC = Arco)", 2, "A = πr² - ABC", "A = ABC.r / 2", "A = ABC - r²", "A = ABC.r.2", 10);
            perguntas_exatas.Add(p10);

            Perguntas p11 = new Perguntas("A área da coroa circular é:", 3, "A = π.r² / 2", "π.R.r / 2", "A = π.R² - π.r²", "A = 2.R.r.π / r²", 10);
            perguntas_exatas.Add(p11);

            Perguntas p12 = new Perguntas("O volume da esfera é:", 3, "V = 4.π.r²", "V = 3.π.r³ / 4", "V = 4.π.r³ / 3", "V = 4.π.r² / 3", 10);
            perguntas_exatas.Add(p12);

            Perguntas p13 = new Perguntas("O volume do cilindro é:", 4, "V = 2.π.r²", "V = π.r.h", "V = 2.π.r².h", "V = π.r².h", 10);
            perguntas_exatas.Add(p13);

            Perguntas p14 = new Perguntas("O volume do cone é:", 2, "V = π.r²", "V = π.r².h / 3", "V = π.r.h / 3", "V = 3.π.r² / 2", 10);
            perguntas_exatas.Add(p14);

            Perguntas p15 = new Perguntas("O volume de um prisma é dado por:", 1, "V = A.b.h", "V = A.b / h", "V = A.b.h / 2", "V = A.b / 2.h", 10);
            perguntas_exatas.Add(p15);

            Perguntas p16 = new Perguntas("O volume da pirâmide é:", 1, "V = A.b.h / 3", "V = b.h / 3", "V = π.b.h", "V = b.h /3", 10);
            perguntas_exatas.Add(p16);

            Perguntas p17 = new Perguntas("O Teorema de Pitágoras é dado por:", 4, "a² = b + c", "a² = b² + c", "a = b² + c²", "a² = b² + c²", 5);
            perguntas_exatas.Add(p17);

            Perguntas p18 = new Perguntas("O cosseno é dado por:", 2, "cos(a) = cat op / cat adj", "cos(a) = cat adj / hip", "cos(a) = cat op / hip", "cos(a) = cat adj / cat op", 10);
            perguntas_exatas.Add(p18);

            Perguntas p19 = new Perguntas("O seno é dado por:", 1, "sen(a) = cat op / hip", "sen(a) = cat adj / hip", "sen(a) = cat op / cat adj", "sen(a) = cat adj / cat op", 10);
            perguntas_exatas.Add(p19);

            Perguntas p20 = new Perguntas("A tangente é dada por:", 3, "tg(a) = cos(a) / hip", "sen(a) / hip", "tg(a) = sen(a) / cos(a)", "tg(a) = cos(a) / sen(a)", 10);
            perguntas_exatas.Add(p20);

            Perguntas p21 = new Perguntas("A relação fundamental da trigonometria é:", 4, "cos²(a) + sen²(a) = tg(a)", "tg(a) + cos(a) = 1", "sen(a²) + cos(a²) = 1", "sen²(a) + cos²(a) = 1", 10);
            perguntas_exatas.Add(p21);

            Perguntas p22 = new Perguntas("A lei dos senos é:", 2, "(senA) = (senB) = (senC)", "(a / senA) = (b / senB) = (c / senC)", "(senA / a) = (senB / b) = (senC / c)", "(senA + a) = (senB + b) = (senC + c)", 10);
            perguntas_exatas.Add(p22);

            Perguntas p23 = new Perguntas("A lei dos cossenos é:", 4, "a = b² + c² - 2.a.b.c.cos(a²)", "a = b² + c² - 2.b.c.cos(a)", "a² = b + c - 2.cos(a)", "a² = b² + c² - 2.b.c.cos(a)", 10);
            perguntas_exatas.Add(p23);

            Perguntas p24 = new Perguntas("O cossecante é:", 1, "cossec(a) = 1 / sen(a)", "cossec(a) = 1 / cos(a)", "cossec(a) = 1 / tg(a)", "cossec(a) = sen(a) + 1", 10);
            perguntas_exatas.Add(p24);

            Perguntas p25 = new Perguntas("A secante é:", 2, "sec(a) = tg(a) / cos(a)", "sec(a) = 1 / cos(a)", "sec(a) = 1 / sen(a)", "sec(a) = 1 / tg(a)", 10);
            perguntas_exatas.Add(p25);

            Perguntas p26 = new Perguntas("A cotangente é:", 4, "cotg(a) = 1 / sen(a)", "cotg(a) = sen(a) / cos(a)", "cotg(a) = cos(a) / sen(a)", "cotg(a) = tg²(a)", 10);
            perguntas_exatas.Add(p26);

            Perguntas p27 = new Perguntas("O Juro simples é representado por:", 3, "J = C.C.(i + t) / t", "J = C.(1 + i) / t", "J = C.i.t", "J = C.i.t / 2", 10);
            perguntas_exatas.Add(p27);

            Perguntas p28 = new Perguntas("O Juros composto é dado por:", 1, "M = C(1 + i).t", "M = C.i.t", "M = C.i / t", "M = C.(1 + i) / t", 10);
            perguntas_exatas.Add(p28);

            Perguntas p29 = new Perguntas("A lei geral da equação do 1° grau é:", 2, "y = a.x", "y = a.x + b", "y = a + b.x", "y = a.x² + b", 5);
            perguntas_exatas.Add(p29);

            Perguntas p30 = new Perguntas("A lei geral da equação do 2° grau é:", 3, "y = a².x + b.x + c", "a.x + b.x + c.x", "y = a.x² + b.x + c", "y = a.x² + c", 5);
            perguntas_exatas.Add(p30);

            Perguntas p31 = new Perguntas("A fórmula de Bhaskara é:", 4, "x = (-b +- sqr(-b - 4.a.c)) / 2.a", "x = (b +- sqr(b² - 4.a.c)) / 2a", "x = (-b +- sqr(b - 4.a.c)) / 2.a", "x = (-b +-sqr(b² - 4.a.c)) / 2.a", 5);
            perguntas_exatas.Add(p31);

            Perguntas p32 = new Perguntas("O resultado da função 7+8x0-2 é:", 3, "13", "-2", "5", "9", 5);
            perguntas_exatas.Add(p32);

            Perguntas p33 = new Perguntas("O resultado da função 7+7÷7+7x7-7 é:", 2, "00", "50", "01", "56", 5);
            perguntas_exatas.Add(p33);

            Perguntas p34 = new Perguntas("Qual das seguintes alternativa representa a equação de Peso de um corpo?", 3, "P = g.h.m", "P = h/g", "P = m.g", "P = g*10", 10);
            perguntas_exatas.Add(p34);

            Perguntas p35 = new Perguntas("Qual das seguintes alternativa representa a equação da Energia potencial gravitacional?", 4, "Epg = m.v.h", "Epg = m.g", "Epg = h.g", "Epg = m.g.h", 10);
            perguntas_exatas.Add(p35);

            Perguntas p36 = new Perguntas("Qual das seguintes alternativa representa a equação da Velocidade Média?", 1, "V = Δd/Δt", "V = Δh/ΔS", "V = Δv/(ΔS-Δt)", "V = Δv+Δt", 5);
            perguntas_exatas.Add(p36);

            Perguntas p37 = new Perguntas("Qual das seguintes alternativa representa a equação da Energia Cinética?", 3, "Ec = m.v²", "Ec = m.v.h²", "Ec = 1/2.m.v²", "Ec = 1/3.m.v²", 10);
            perguntas_exatas.Add(p37);

            Perguntas p38 = new Perguntas("Qual das seguintes alternativa representa a equação da Energia potencial elástica?", 1, "Epe = 1/2.k.x²", "Epe = 1/2.x²", "Epe = k.x²", "Epe = k.x².h", 10);
            perguntas_exatas.Add(p38);

            Perguntas p39 = new Perguntas("Qual das alternativa representa a formula da Aceleração?", 2, "A = Δv/ΔS", "A = Δv/Δt", "A = Δv/m", "A = Δv/g", 5);
            perguntas_exatas.Add(p39);

            Perguntas p40 = new Perguntas("O valor de π(pi) é correspondente a qual alternativa?", 4, "3,20", "2,5", "3,16", "3,14", 5);
            perguntas_exatas.Add(p40);

            Perguntas p41 = new Perguntas("O valor de e(Euler) é correspondente a qual alternativa?", 3, "3,14", "2,1", "2,71", "1,4", 5);
            perguntas_exatas.Add(p41);

            Perguntas p42 = new Perguntas("A equação que representa o volume de um cubo é:", 1, "V = a.a.a", "V = a.a", "V = a.h", "V = a/h", 5);
            perguntas_exatas.Add(p42);

            Perguntas p43 = new Perguntas("Qual o resultado da função ((2³+(64÷16)) + (6²x6)) x (16 - 32/2)?", 1, "0", "228", "720", "528", 10);
            perguntas_exatas.Add(p43);

            Perguntas p44 = new Perguntas("Qual o resultado da função 0x2x7²+(3+3)+100÷10?", 4, "50", "0", "30", "16", 10);
            perguntas_exatas.Add(p44);

            Perguntas p45 = new Perguntas("'0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...\' Essa sequência recebeu o nome de qual matemático?", 4, "Isaac Newton", "Leonhard Euler", "Arquimedes de Siracusa", "Leandro Fibonacci", 10);
            perguntas_exatas.Add(p45);

            Perguntas p46 = new Perguntas("Os triângulos com ângulos menores que 90° e maiores que 90° são chamados respectivamente de:", 1, "Acutângulo e obtusângulo", "Obtusângulo e acutângulo", "Retângulo e obtusângulo", "Acutângulo e retângulo", 10);
            perguntas_exatas.Add(p46);

            Perguntas p47 = new Perguntas("O (pi) é um número irracional e que tem relação com uma das mais importantes figuras da geometria. Essa figura é o:", 3, "Triângulo", "Quadrado", "Círculo", "Losango", 5);
            perguntas_exatas.Add(p47);

            Perguntas p48 = new Perguntas("Existem alguns ângulos chamados notáveis, os quais seus valores devem ser conhecidos. Esses ângulos são:", 2, "35°, 45° e 60°", "30°, 45° e 60°", "30°, 40° e 65°", "35°, 40° e 65°", 5);
            perguntas_exatas.Add(p48);

            Perguntas p49 = new Perguntas("A soma dos ângulos internos de um triângulo é:", 2, "90°", "180°", "270°", "360°", 5);
            perguntas_exatas.Add(p49);

            Perguntas p50 = new Perguntas("Qual dos abaixo não é um tipo de paralelogramo?", 3, "Retângulo", "Losango", "Triângulo", "Quadrado", 5);
            perguntas_exatas.Add(p50);
        }
    }

}
