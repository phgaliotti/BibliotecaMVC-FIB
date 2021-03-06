﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O campo Nome não pode ter mais do que {1} caracteres")]
        public string Nome { get; set; }

        public ICollection<LivroAutor> LivroAutor { get; set; }
    }
}
