CREATE DATABASE db_doceria;
USE db_doceria;

CREATE TABLE tb_usuarios (
	id_usuario int auto_increment,
    cpf varchar (12),
    nome varchar(50),
    pontos int (4),
    
    primary key (id_usuario)
);

CREATE TABLE tb_categorias (
	id_categoria int auto_increment,
    nome_categoria varchar(20),
    
    primary key (id_categoria)
);

CREATE TABLE tb_sabores (
	id_sabor int auto_increment,
	nome_sabor varchar(20),
    
    primary key (id_sabor)
);

CREATE TABLE tb_produtos (
	id_produto int auto_increment,
    
    imagem varchar (150),
    nome varchar (20),
    descricao varchar (150),
    valor decimal (5,2),
    
    /*quantidade int ,*/
    id_categoria varchar(20),
	id_sabor varchar(20),
    
    primary key (id_produto),
    foreign key (id_categoria) references tb_categorias(id_categoria),
	foreign key (id_sabor) references tb_sabores(id_sabor)
);

CREATE TABLE tb_notas_fiscais(
	id_nota_fiscal varchar(20),
    
	valor_total decimal (6,2),
    forma_de_pagamento varchar(20),
	/*status_pagamento varchar(20),*/
    
	id_usuario varchar(20),
    /*id_item varchar(20),*/
	
    primary key (id_nota_fiscal),
	foreign key (id_usuario) references tb_usuarios(id_usuario)
    /*foreign key (id_item) references tb_nf_item(id_item)*/
);

CREATE TABLE tb_nf_item(
	id_nf_item int auto_increment,
    
    quantidade_produto int(4),
	id_produto int,
    id_nota_fiscal varchar(20),
    
	primary key (id_nf_item),
	foreign key (id_produto) references tb_produtos(id_produto),
    foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);

CREATE TABLE tb_sabor (
	id_sabores varchar (20),
    
	primary key(id_sabores)


);
SELECT * FROM tb_produtos;

/**/
/*EXEMPLO PROFESSOR */
CREATE DATABASE db_loja;

USE db_loja;

CREATE TABLE tb_categoriass(
	id int auto_increment,
    nome varchar (50),
    primary key (id)
);

CREATE TABLE tb_produtoss(
	id int auto_increment,
    nome varchar (50),
    descricao varchar (150),
    valor decimal (6,2),       /*6 casas dessas 6 2 são destinadas aos centavos*/
    url_imagem varchar (150),  /*link imagem*/
    blob_imagem mediumblob,    /*blob imagem*/
    
    categoria int,
    primary key (id),
    foreign key (categoria) references tb_categoriass(id)
);

INSERT INTO tb_categoriass (nome)
VALUES 
('Eletrônicos'),
('Livros'),
('Jogos'),
('Música'),
('Cinema'),
('Automóveis'),
('Educação'),
('Gastronomia'),
('Turismo'),
('Fitness');

INSERT INTO tb_produtoss (nome, descricao, valor, url_imagem, blob_imagem, categoria)
VALUES 
('Smartphone X', 'Celular com câmera avançada e tela OLED.', 2499.99, 'https://exemplo.com/smartphone.jpg', NULL, 1),
('Notebook Pro', 'Notebook leve e potente para trabalho e estudo.', 4999.99, 'https://exemplo.com/notebook.jpg', NULL, 1),
('Livro de Ficção', 'Romance emocionante que prende a atenção.', 79.90, 'https://exemplo.com/livro.jpg', NULL, 2),
('Fones Bluetooth', 'Áudio de alta qualidade sem fio.', 399.99, 'https://exemplo.com/fones.jpg', NULL, 1),
('Teclado Mecânico', 'Teclado gamer com iluminação RGB.', 599.99, 'https://exemplo.com/teclado.jpg', NULL, 1),
('Câmera Fotográfica', 'Câmera profissional para alta resolução.', 3299.90, 'https://exemplo.com/camera.jpg', NULL, 1),
('Tênis Esportivo', 'Calçado confortável para corrida e treino.', 399.90, 'https://exemplo.com/tenis.jpg', NULL, 7),
('Moletom Casual', 'Moletom estiloso e confortável.', 199.90, 'https://exemplo.com/moletom.jpg', NULL, 5),
('Cadeira Gamer', 'Cadeira ergonômica para maior conforto.', 1299.99, 'https://exemplo.com/cadeira.jpg', NULL, 1),
('Relógio Smart', 'Relógio inteligente com monitoramento de saúde.', 899.99, 'https://exemplo.com/relogio.jpg', NULL, 1);





drop table tb_categoriass;
/* comentarios*/


/*SELECT * FROM tb_produtos 
INNER JOIN tb_categorias ON id_categoria = 
WHERE  /*quantidade > 0 */

/*CREATE TABLE tb_nf_pagamentos(
	id_pagamento varchar(20),
    status_pagamento varchar(20),
	forma_de_pagamento varchar(20),
   /* id_nota_fiscal varchar(20),*/
    
	/*primary key (id_pagamento)
    /*foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);*/



 
 /*alter table
drop table tb;
*/

/*INSERT INTO tb_usuarios (nome, pontos)
VALUES 
('Maria', 100), 
('João', 200), 
('Ana', 300), 
('Carlos', 150), 
('Beatriz', 250), 
('Lucas', 180), 
('Fernanda', 220), 
('Ricardo', 190), 
('Juliana', 210), 
('Gabriel', 170);
select * from tb_usuarios; */