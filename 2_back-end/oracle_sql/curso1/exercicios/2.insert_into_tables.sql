INSERT INTO tb_produtos (
    produto,
    nome,
    embalagem,
    tamanho,
    sabor,
    preco_lista
) VALUES (
    '1040107',
    'Light',
    'Lata',
    '350mL',
    'Melancia',
    4.56
);

INSERT INTO tb_produtos (
    produto,
    nome,
    embalagem,
    tamanho,
    sabor,
    preco_lista
) VALUES (
    '1037797',
    'Clean',
    'PET',
    '2L',
    'Laranja',
    16.01
);

INSERT INTO tb_produtos (
    produto,
    nome,
    embalagem,
    tamanho,
    sabor,
    preco_lista
) VALUES (
    '1000889',
    'Sabor da Montanha',
    'Garrafa',
    '700mL',
    'Uva',
    6.31
);

INSERT INTO tb_produtos (
    produto,
    nome,
    embalagem,
    tamanho,
    sabor,
    preco_lista
) VALUES (
    '544931',
    'Frescor do Verão',
    'PET',
    '350mL',
    'Limão',
    3.20
);

INSERT INTO tb_produtos (
    produto,
    nome,
    embalagem,
    tamanho,
    sabor,
    preco_lista
) VALUES (
    '1078680',
    'Frescor do Verão',
    'Lata',
    '470mL',
    'Manga',
    5.18
);

INSERT INTO tb_vendedores (
    matricula,
    nome,
    percentual_comissao
) VALUES (
    '00233',
    'José Geraldo da Fonseca',
    0.1
);

INSERT INTO tb_vendedores (
    matricula,
    nome,
    percentual_comissao
) VALUES (
    '00235',
    'Márcio Almeida Silva',
    0.08
);

INSERT INTO tb_vendedores (
    matricula,
    nome,
    percentual_comissao
) VALUES (
    '00236',
    'Cláudia Morais',
    0.08
);

select * from tb_produtos;
select * from tb_vendedores;