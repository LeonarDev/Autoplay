g_cli_lim_fatur_pequeno NUMBER(10) := 10000;
g_cli_lim_fatur_medio NUMBER(10) := 50000;
g_cli_lim_fatur_medio_grande NUMBER(10) := 90000;


    IF p_faturamento_previsto <= g_cli_lim_fatur_pequeno THEN 
       RETURN 'PEQUENO';
    ELSIF p_faturamento_previsto <= g_cli_lim_fatur_medio THEN
       RETURN 'MEDIO';
    ELSIF p_faturamento_previsto <= g_cli_lim_fatur_medio_grande  THEN
       RETURN 'MEDIO GRANDE';
    ELSE
       RETURN 'GRANDE';
    END IF;   