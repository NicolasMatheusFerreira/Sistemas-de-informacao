.data
	idade: .word 56 # Valor 56 atribuido a minha vari�vel do tipo (.word) equivalente ao um int (integer) <- Vindo a mem�ria RAM.
	nome: .ascii "Nicolas"
.text	
	lw $a0, idade
	li $v0, 1
	syscall	
	
	li $v0, 10 # C�digo para interromper o programa		
					
	la $a0, nome # Carrega conte�do vindo da vari�vel nome para o registrador $a1					
	li $v0, 4 # Carrega para o registrador $v1 o c�digo de impressao para printar na tela
	syscall
	
	li $v0, 10 # C�digo para interromper o programa
.main:	
