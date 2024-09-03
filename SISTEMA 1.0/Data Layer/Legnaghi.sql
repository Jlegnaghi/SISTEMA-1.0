use jefferso_SISTEMA;

CREATE TABLE equipamento (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    PSU_Marca VARCHAR(50),
    PSU_Potencia VARCHAR(50),
    CPU_Marca VARCHAR(50),
    CPU_Modelo VARCHAR(50),
    MOBO_Marca VARCHAR(50),
    MOBO_Modelo VARCHAR(50),
    GPU_Presente BOOLEAN,
    GPU_Marca VARCHAR(50),
    GPU_Modelo VARCHAR(50),
    MEM_Tipo VARCHAR(50),
    MEM_Tamanho VARCHAR(50),
    Disco_Tipo VARCHAR(50),
    Disco_Marca VARCHAR(50),
    Disco_Tamanho VARCHAR(50),
    Teclado_Marca VARCHAR(50),
    Mouse_Marca VARCHAR(50),
    Monitor_Tamanho VARCHAR(50),
    Setor VARCHAR(50),
    Numero_Patrimonio VARCHAR(50),
    Tecnico_Responsavel VARCHAR(50),
    Data_Entrada DATE,
    Codigo_ID VARCHAR(50),
    Descricao_Problema TEXT,
    Imagem_Gabinete BLOB
);