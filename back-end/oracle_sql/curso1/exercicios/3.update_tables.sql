SELECT * FROM tb_produtos;

UPDATE tb_produtos
    SET
        embalagem = 'Lata',
        preco_lista = 2.46
    WHERE
        cod_produto = '544931';

UPDATE tb_produtos
    SET
        embalagem = 'Garrafa'
    WHERE
        cod_produto = '1078680';

SELECT * FROM tb_vendedores;

UPDATE tb_vendedores
    SET
        percentual_comissao = 0.11
    WHERE 
        matricula = '00236';
        
UPDATE tb_vendedores
    SET
        nome = 'José Geraldo da Fonseca Junior'
    WHERE 
        matricula = '00236';