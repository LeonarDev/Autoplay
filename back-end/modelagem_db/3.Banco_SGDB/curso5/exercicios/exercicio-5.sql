SELECT 
    tb_funcionario.PRIMEIRO_NOME,
    tb_funcionario.NOME_MEIO,
    tb_funcionario.ULTIMO_NOME
FROM
    tb_funcionario
        LEFT JOIN
    tb_dependente ON tb_funcionario.cpf = tb_dependente.CPF_FUNCIONARIO
WHERE
    tb_dependente.CPF_FUNCIONARIO IS NULL