.data
	meuNome: .ascii "Nicolas Matheus Ferreira." # Nessa vari�vel fica meu nome guardado
.text
	.main:
	la $a0, meuNome
	jal imprime
	li $v0, 10 # Informa que o programa acabou
	
	syscall
	
	imprime:
		li $v0, 4
		syscall
		jr $ra # Volta para chamada da fun��o
	syscall
	
