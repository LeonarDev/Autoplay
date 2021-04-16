SELECT 
    tb_funcionario.PRIMEIRO_NOME, tb_funcionario.ULTIMO_NOME, tb_funcionario.ENDERECO
FROM
    tb_funcionario
        INNER JOIN
    tb_departamento ON tb_funcionario.NUMERO_DEPARTAMENTO = tb_departamento.NUMERO_DEPARTAMENTO
WHERE
    tb_departamento.NOME_DEPARTAMENTO = 'Pesquisa';