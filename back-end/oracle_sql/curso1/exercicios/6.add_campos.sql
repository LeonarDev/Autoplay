ALTER TABLE tb_vendedores ADD de_ferias NUMBER(1);

ALTER TABLE tb_vendedores ADD data_admissao DATE;

SELECT * FROM tb_vendedores;

UPDATE tb_vendedores
SET
    data_admissao = TO_DATE('15/08/2014', 'DD,MM,YYYY'),
    de_ferias = 0
WHERE
    matricula = '00235';
    
UPDATE tb_vendedores
SET
    nome = 'Cláudia Morais',
    percentual_comissao = 0.08,
    data_admissao = TO_DATE('17/09/2013', 'DD,MM,YYYY'),
    de_ferias = 1
WHERE
    matricula = '00236';

INSERT INTO tb_vendedores (
    matricula,
    nome,
    percentual_comissao,
    data_admissao,
    de_ferias
) VALUES (
    '00237',
    'Roberta Martins',
    0.11,
    to_date('18-03-2017', 'DD,MM,YYYY'),
    1
);

INSERT INTO tb_vendedores (
    matricula,
    nome,
    percentual_comissao,
    data_admissao,
    de_ferias
) VALUES (
    '00238',
    'Péricles Alves',
    0.11,
    to_date('21-08-2016', 'DD,MM,YYYY'),
    0
);