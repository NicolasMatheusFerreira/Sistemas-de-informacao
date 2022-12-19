# Pontif�cia Universidade Cat�lica de Minas Gerais
# Curso Sistemas de informa��o
# Disciplina Arquitetura de Computadores

# Questao 3
	.data
		palavra: .space 101	
		pergunta: .ascii "Informe uma palavra: "		
		valor: .word
	.text
		.main:
			li $v0, 4 # D� permissao de sa�da de dados na tela
			la $a0, pergunta
			syscall
			
			jal LerString
			jal ImprimeString
			jal LerInteiro
			jal ImprimeInteiro
					
			li $v0, 10 # Informa ao sistema que � para finalizar o programa
			syscall
		LerString:
			li $v0, 8 # Da permiss�o para leitura
			la $a0, palavra # Atribui cont�udo guardado no espa�o de mem�ria reservado a palavra para o registrador $a0
			li $a1, 101 # Informa a quantidade de bytes 
			syscall
			jr $ra # Retorna para a chamada da fun��o
		ImprimeString:
			la $a0, palavra
			li $v0, 4
			syscall
			jr $ra
