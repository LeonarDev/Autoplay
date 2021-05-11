SELECT 
    tb_projeto.NUMERO_PROJETO,
    tb_projeto.NUMERO_DEPARTAMENTO,
    tb_funcionario.ULTIMO_NOME,
    tb_funcionario.ENDERECO,
    tb_funcionario.DATA_NASCIMENTO
FROM
    tb_projeto
        INNER JOIN
    tb_departamento ON tb_departamento.NUMERO_DEPARTAMENTO = tb_projeto.NUMERO_DEPARTAMENTO
        INNER JOIN
    tb_funcionario ON tb_funcionario.CPF = tb_departamento.CPF_GERENTE
WHERE
    tb_projeto.LOCAL_PROJETO = 'Mauá';