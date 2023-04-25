	.data
		pergunta: .ascii "Qual e seu nome: "
		nome: .space 33
	.text
		# Impressao da pergunta
		li $v0, 4
		la $a0, pergunta
		syscall
		
		# Leitura do nome
		li $v0, 8
		la $a0, nome
		la $a1, 33
		syscall
		
		li $v0, 10
