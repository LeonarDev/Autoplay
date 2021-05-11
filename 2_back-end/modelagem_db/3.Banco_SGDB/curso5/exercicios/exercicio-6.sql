SELECT DISTINCT
    tb_funcionario.PRIMEIRO_NOME,
    tb_funcionario.NOME_MEIO,
    tb_funcionario.ULTIMO_NOME
FROM
    tb_funcionario
        INNER JOIN
    tb_dependente ON tb_funcionario.cpf = tb_dependente.CPF_FUNCIONARIO
        INNER JOIN
    tb_departamento ON tb_funcionario.CPF = tb_departamento.CPF_GERENTE