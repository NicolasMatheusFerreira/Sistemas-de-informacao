	.text
		li $s0, 100000
		li $s1, 1200
		mul $s2, $s0, $s1
		mul $s3, $s0, $s1
		
		li $v0, 1
		move $a0, $s2
		
		syscall
		li $a0, 10
		
	.data