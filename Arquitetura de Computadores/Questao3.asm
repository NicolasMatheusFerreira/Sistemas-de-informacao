# Pontifícia Universidade Católica de Minas Gerais
# Curso Sistemas de informação
# Disciplina Arquitetura de Computadores

# Questao 3
	.data
		palavra: .space 101	
		pergunta: .ascii "Informe uma palavra: "		
		valor: .word
	.text
		.main:
			li $v0, 4 # Dá permissao de saída de dados na tela
			la $a0, pergunta
			syscall
			
			jal LerString
			jal ImprimeString
			jal LerInteiro
			jal ImprimeInteiro
					
			li $v0, 10 # Informa ao sistema que é para finalizar o programa
			syscall
		LerString:
			li $v0, 8 # Da permissão para leitura
			la $a0, palavra # Atribui contéudo guardado no espaço de memória reservado a palavra para o registrador $a0
			li $a1, 101 # Informa a quantidade de bytes 
			syscall
			jr $ra # Retorna para a chamada da função
		ImprimeString:
			la $a0, palavra
			li $v0, 4
			syscall
			jr $ra
