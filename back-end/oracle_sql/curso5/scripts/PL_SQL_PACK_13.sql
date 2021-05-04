
CREATE OR REPLACE PACKAGE EXCEPTION_PAC

IS

   e_null exception;
   pragma exception_init (e_null, -1400);
   
   e_fk exception;
   pragma exception_init (e_fk, -2291);

END;

INSERT INTO CLIENTE VALUES (NULL, 'AAAA', '12345', 2, SYSDATE, 100000, '');
INSERT INTO CLIENTE VALUES (20, 'AAAA', '12345', 300, SYSDATE, 100000, '');

