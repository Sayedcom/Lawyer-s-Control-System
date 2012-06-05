<?php
/*
*            ....
*           ||''|| 			
*       _____||||_____					
*  >---|              |---< 	SERVICIOWEB PARA SISTEMA FISCAL DE ABOGADOS	 
*       \            / 			Por: Laura Gonzalez.
*        \__      __/  			Instituto Tecnológico de Tijuana
*           |     |
*           |     |
* 		   /	   \
*		  |_________|
*/

//clases para configurar conexion unica a la base de datos y rehusarla (Singleton)
require("config.inc.php");
require("Database.singleton.php");

require_once("lib/nusoap.php");
$namespace = "http://vgcorporativo.com/sistema";

// create a new soap server
$server = new soap_server();
// configure our WSDL
$server->configureWSDL("ServicioCasosFiscales");
// set our namespace
$server->wsdl->schemaTargetNamespace = $namespace;


$db = Database::obtain(DB_SERVER, DB_USER, DB_PASS, DB_DATABASE);
$db->connect();
	
//Metodo para iniciar sesion
function login($email,$password)
{
	//conexion a la base de datos
	$db = Database::obtain();
	$sql="SELECT Email,Password FROM Abogado WHERE Email='".$db->escape($email)."'";
    $row = $db->query_first($sql);
    
    // verifica si el correo existe y fue encontrado en la tabla
    if(!empty($row['Email']))
        {
			//compara campo de password de la consulta con el del parametro
			if ($row['Password'] == $password)
				return true;
			else
				//si no coincide manda falso
				return false;
		}
    else
		//si no existe el correo manda falso
        return false;
		
}

/*****************************************************************************
*
* 			METODOS INSERT PARA LAS TABLAS:  
*			Abogado,Cliente, Archivo, Asunto, *			*											
*			Autoridad,  Cita, Convenio, Dias_No_Habiles, Estado_Asunto, 		*			* 			Estado_Proceso, Etapa, Pago, Proceso, Tipo_Moneda
*
*
*******************************************************************************/

//Funcion para agregar abogados
function addAbogados($nombre,$email,$password,$fechan,$direccion,$telefono,$celular,$nextel,$superusuario)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Abogado (Nombre, Email,Password,FechaN,Direccion,Telefono,Celular,Nextel,Superusuario) VALUES('%s','%s','%s','%s','%s','%s','%s','%s','%s')",
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($email),
			mysql_real_escape_string($password),
            mysql_real_escape_string($fechan),
			mysql_real_escape_string($direccion),
            mysql_real_escape_string($telefono),
			mysql_real_escape_string($celular),
            mysql_real_escape_string($nextel),
			mysql_real_escape_string($superusuario)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa";
	
}


//Funcion para agregar clientes
function addCliente($nombre,$email,$fechan,$direccion,$telefono,$celular,$nextel)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Cliente (Nombre, Email,FechaN,Direccion,Telefono,Celular,Nextel) VALUES('%s','%s','%s','%s','%s','%s','%s')",
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($email),
            mysql_real_escape_string($fechan),
			mysql_real_escape_string($direccion),
            mysql_real_escape_string($telefono),
			mysql_real_escape_string($celular),
            mysql_real_escape_string($nextel)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}


//Funcion para agregar Archivos a la base de datos 
function addArchivo($id_etapa,$id_asunto,$descripcion,$nombre,$ruta,$tamanoe)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Archivo (ID_Etapa, ID_Asunto,Descripcion,nombre,ruta,tamano) 
										VALUES('%s','%s','%s','%s','%s','%s')",
            mysql_real_escape_string($id_etapa),
            mysql_real_escape_string($id_asunto),
			mysql_real_escape_string($descripcion),
            mysql_real_escape_string($nombre),
			mysql_real_escape_string($ruta),
            mysql_real_escape_string($tamano)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Archivo guardado";
	
}



//Funcion para agregar Asunto
function addAsunto($nombre,$descripcion,$fechainicio,$fechafin,$id_estado,$id_proceso,$id_autoridad, $id_cliente, $id_abogado)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Asunto (Nombre, Descripcion,Fecha_inicio,Fecha_fin,ID_Estado,ID_Proceso,ID_Autoridad,ID_Cliente,ID_Abogado) VALUES('%s','%s','%s','%s','%s','%s','%s','%s','%s')",
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($descripcion),
            mysql_real_escape_string($fechainicio),
			mysql_real_escape_string($fechafin),
            mysql_real_escape_string($id_estado),
			mysql_real_escape_string($id_proceso),
            mysql_real_escape_string($id_autoridad),
			mysql_real_escape_string($id_cliente),
            mysql_real_escape_string($id_abogado)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}



//Funcion para agregar Autoridades
function addAutoridad($nombre,$direccion,$telefono)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Autoridad (Nombre, Direccion,Telefono) VALUES('%s','%s','%s')",
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($direccion),
            mysql_real_escape_string($telefono)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}

//Funcion para agregar Cita
function addCita($id_cliente,$id_asunto,$id_abogado,$lugar,$fecha,$hora)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Cita (ID_Cita,ID_Cliente, ID_Asunto, ID_Abogado, Lugar, Fecha, Hora) VALUES('%s','%s','%s','%s','%s','%s', '%s')",
            mysql_real_escape_string($id_cliente),
            mysql_real_escape_string($id_asunto),
            mysql_real_escape_string($id_abogado),
			mysql_real_escape_string($lugar),
			mysql_real_escape_string($fecha),
			mysql_real_escape_string($hora)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}


//INSERT Convenio

//Funcion para agregar convenios
function addConvenio($id_asunto,$cantidad, $descripcion, $id_tipo_moneda)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Convenio (ID_Asunto, Cantidad, Descripcion, ID_Tipo_Moneda) VALUES('%s','%s','%s','%s')",
            mysql_real_escape_string($id_asunto),
            mysql_real_escape_string($cantidad),
			mysql_real_escape_string($descripcion),
            mysql_real_escape_string($id_tipo_moneda)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";
	
}


//Funcion para agregar Dias no hábiles
function addDiaNoHabil($dia)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Dias_No_Habiles (Dia) VALUES('%s')",
            mysql_real_escape_string($dia)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}

//Funcion para agregar Estado_Asunto
function addEstadoAsunto($nombre,$descripcion)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Estado_Asunto (Nombre,Descipcion) VALUES('%s','%s')",
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($descripcion)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}


//Funcion para agregar Estado_Proceso
function addEstadoProceso($nombre,$descripcion,$dias_vencimiento)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Estado_Proceso (Nombre,Descipcion,Dias_Vencimiento) VALUES('%s','%s','%s')",
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($descripcion),
			mysql_real_escape_string($dias_vencimiento)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}

//Funcion para agregar Etapas
function addEtapa($id_asunto,$fecha_inicio,$descripcion,$id_estadoproceso)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Etapa (ID_Asunto,Fecha_Inicio,Descripcion,ID_EstadoProceso) 
										VALUES('%s','%s','%s','%s')",
            
            mysql_real_escape_string($id_asunto),
            mysql_real_escape_string($fecha_inicio),
			mysql_real_escape_string($descripcion),
			mysql_real_escape_string($id_estadoproceso)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";
	
}

//Funcion para agregar Pagos
function addPago($id_convenio,$id_asunto,$cantidad,$fecha)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Pago (ID_Convenio, ID_Asunto,Cantidad,Fecha) 
										VALUES('%s','%s','%s','%s')",
            mysql_real_escape_string($id_convenio),
            mysql_real_escape_string($id_asunto),
			mysql_real_escape_string($cantidad),
			mysql_real_escape_string($id_fecha)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";
}

//Funcion para agregar Proceso Fiscal;
function addProceso($numeroetapas,$nombre,$descripcion)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Procesoo (NumeroEtapas,Nombre,Descripcion) 
										VALUES('%s','%s','%s')",
            mysql_real_escape_string($numeroetapas),
			mysql_real_escape_string($nombre),
			mysql_real_escape_string($descripcion)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";
}


//Funcion para agregar Dias no hábiles
function addTipoMoneda($nombre)
{
	$db = Database::obtain();
	
	$q = sprintf("INSERT INTO Tipo_Moneda (Nombre) VALUES('%s')",
            mysql_real_escape_string($nombre)
			);
	
	$result = mysql_query($q) or die(mysql_error()); 
	if (mysql_error())
	return $result;
	else
	return "Insercion exitosa!";	
}
/***********************************************************************
*
* 			METODOS DELETE PARA LAS TABLAS:  Abogado,Cliente, Asunto,Autoridad,cita,Convenio, Dias no habiles, Estado_Asunto,EstadoProceso
*
*
*************************************************************************/

//Funcion para eliminar algun campode la tabla abogados
function deleteAbogados($id_abogado)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Abogado WHERE ID_Abogado='%s' ;",
						  mysql_escape_string($id_abogado)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}

// Delete Cliente
function deleteCliente($id_cliente)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Cliente WHERE ID_Cliente='%s' ;",
						  mysql_escape_string($id_cliente)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}

//Delete Asunto

function deleteAsunto($id_asunto)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Asunto WHERE ID_Asunto='%s' ;",
						  mysql_escape_string($id_asunto)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}

//Delete Archivo

function deleteArchivo($nombre)
{
	
	$db = Database::obtain();
	$query = sprintf("SELECT * FROM Archivo WHERE Nombre='%s' ;",
						  mysql_escape_string($nombre)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	
	
     while ($row= mysql_fetch_row($result))
		{
			$nombreArchivo = $row[4]; //solo solicito nombre
			
		}
		$nombreArchivo = './archivos/'.$nombreArchivo;
		if(file_exists($nombreArchivo))
		{
		unlink($nombreArchivo);
		$query = sprintf("DELETE FROM Archivo WHERE Nombre='%s' ;", mysql_escape_string($nombre));	
		$result = mysql_query($query) 
		or die(mysql_error());
		}
	   
	if($result=="1")
	{		
		return "Archivo Eliminado";
	}
		else 
		return $nombreArchivo;

}

function deleteAutoridad($id_autoridad)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Autoridad WHERE ID_Autoridad='%s' ;",
						  mysql_escape_string($id_autoridad)			  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}


//delete cite

function deleteCita($id_cita)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Cita WHERE ID_Cita='%s' ;",
						  mysql_escape_string($id_cita)			  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}



//Funcion para eliminar algun campode la tabla convenio
function deleteConvenio($id_convenio)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Convenio WHERE ID_Convenio='%s' ;",
						  mysql_escape_string($id_convenio)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}



//Funcion para eliminar algun campode la tabla dia no habil
function deleteDiaNoHabil($id_dianohabil)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Dias_No_Habiles WHERE ID_DiaNoHabil='%s' ;",
						  mysql_escape_string($id_dianohabil)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}


//Funcion para eliminar algun campo de la tabla estado_asunto
function deleteEstadoAsunto($id_estado)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Estado_Asunto WHERE ID_Estado='%s' ;",
						  mysql_escape_string($id_estado)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}

//Funcion para eliminar algun campo de la tabla Estado_Proceso
function deleteEstadoProceso($id_estado)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Estado_Proceso WHERE ID_EstadoProceso='%s' ;",
						  mysql_escape_string($id_estado)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}

//Funcion para eliminar algun campo de la tabla Etapa
function deleteEtapa($id_etapa)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Etapa WHERE ID_Etapa='%s' ;",
						  mysql_escape_string($id_etapa)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}


//Funcion para eliminar algun campo de la tabla Pago
function deletePago($id_pago)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Pago WHERE ID_Pago='%s';",
						  mysql_escape_string($id_pago)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}


//Funcion para eliminar algun campo de la tabla Tipo_Moneda

function deleteTipoMoneda($id_tipo_moneda)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Tipo_Moneda WHERE ID_Tipo_Moneda='%s';",
						  mysql_escape_string($id_tipo_moneda)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}


//Funcion para eliminar algun campo de la tabla Proceso
function deleteProceso($id_proceso)
{
	$db = Database::obtain();
	$query = sprintf("DELETE FROM Proceso WHERE ID_Proceso='%s';",
						  mysql_escape_string($id_proceso)						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Campo Eliminado";
		else
		return $result;
}


/*********************************************************************
*
* 			METODOS UPDATE PARA LAS TABLAS:  Abogado,Cliente,Asunto, Autoridad
*			Cita, Dias_No_Habiles,Estado_Asunto, Estado_Proceso
*
*********************************************************************/

//Funcion update para la tabla abogados
function updateAbogados($id_abogado,$nombre,$email,$password,$fechan,$direccion,$telefono,$celular,$nextel,$superusuario)
{
	$db = Database::obtain();
	
	$query = sprintf("UPDATE Abogado SET Nombre='%s', Email='%s' , Password='%s' , FechaN='%s' , Direccion='%s' , Telefono='%s' , Celular='%s', Nextel='%s',Superusuario='%s' WHERE ID_Abogado='%s' ;",
					  mysql_escape_string($nombre),
						  mysql_escape_string($email),
						  mysql_escape_string($password),
						  mysql_escape_string($fechan),
						  mysql_escape_string($direccion),
						  mysql_escape_string($telefono),
						  mysql_escape_string($celular),
						  mysql_escape_string($nextel),
						  
						  mysql_escape_string($superusuario),
						  mysql_escape_string($id_abogado)
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

//Funcion update para la tabla abogados
function updateCliente($id_cliente,$nombre,$email,$fechan,$direccion,$telefono,$celular,$nextel)
{
	$db = Database::obtain();
	
	$query = sprintf("UPDATE Cliente SET Nombre='%s', Email='%s' , FechaN='%s' , Direccion='%s' , Telefono='%s' , Celular='%s', Nextel='%s' WHERE ID_Cliente='%s' ;",
					      mysql_escape_string($nombre),
						  mysql_escape_string($email),
						  mysql_escape_string($fechan),
						  mysql_escape_string($direccion),
						  mysql_escape_string($telefono),
						  mysql_escape_string($celular),
						  mysql_escape_string($nextel),
						  mysql_escape_string($id_cliente)
						  
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}


//Funcion update para la tabla asuntos
function updateAsunto($id_asunto,$nombre,$descripcion,$fechainicio,$fechafin,$id_estado,$id_proceso,$id_autoridad, $id_cliente, $id_abogado)
{
	$db = Database::obtain();
	
	$query = sprintf("UPDATE Asunto SET Nombre='%s',Descripcion='%s' , Fecha_inicio='%s' , Fecha_Fin='%s' , ID_Estado='%s' , ID_Proceso='%s' , ID_Autoridad='%s', ID_Cliente='%s', ID_Abogado='%s' WHERE ID_Asunto='%s' ;",
					  mysql_escape_string($nombre),
						  mysql_escape_string($descripcion),
						  mysql_escape_string($fechainicio),
						  mysql_escape_string($fechafin),
						  mysql_escape_string($id_estado),
						  mysql_escape_string($id_proceso),
						  mysql_escape_string($id_autoridad),						  						  
					    	mysql_real_escape_string($id_cliente),
          				  mysql_real_escape_string($id_abogado),
						  mysql_escape_string($id_asunto)
						  );	
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

//UPDATE AUTORIDAD
function updateAutoridad($nombre,$direccion,$telefono)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Autoridad SET Nombre='%s', Direccion'%s', Telefono='%s'",
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($direccion),
            mysql_real_escape_string($telefono)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}



//Funcion update para la tabla CITA
function updateCita($id_cita,
					$id_cliente,$id_asunto,$id_abogado,$lugar,$fecha,$hora)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Cita (ID_Cita,ID_Cliente, ID_Asunto, ID_Abogado, Lugar, Fecha, Hora) VALUES('%s','%s','%s'.'%s','%s','%s', '%s')",
            mysql_real_escape_string($id_cliente),
            mysql_real_escape_string($id_asunto),
            mysql_real_escape_string($id_abogado),
			mysql_real_escape_string($lugar),
			mysql_real_escape_string($fecha),
			mysql_real_escape_string($hora)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}


//UPDATE CONVENIO
function updateConvenio($id_convenio, $id_asunto, $cantidad,$descripcion,$id_tipo_moneda)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Convenio SET ID_Asunto='%s', Cantidad='%s', Descripcion='%s',ID_Tipo_Moneda='%s'",
            mysql_real_escape_string($id_convenio),
            mysql_real_escape_string($id_asunto),
            mysql_real_escape_string($cantidad),
			mysql_real_escape_string($descripcion),
			mysql_real_escape_string($id_tipo_moneda)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}


//UPDATE DIAS NO HABILES
function updateDiaNoHabil($id_dianohabil,$dia)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Dias_No_Habiles SET Dia='%s' WHERE ID_DiaNoHabil='%s'",
            mysql_real_escape_string($dia),
			mysql_real_escape_string($id_dianohabil)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

//UPDATE ESTADO_ASUNTO

function updateEstadoAsunto($id_estado,$nombre,$descripcion)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Estado_Asunto SET Nombre='%s',Descripcion='%s'
					 WHERE ID_Estado= '%s'",
            
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($descripcion),
			mysql_real_escape_string($id_estado)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

//UPDATE Estado_Proceso

function updateEstadoProceso($id_estado,$nombre,$descripcion,$dias_vencimiento)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Estado_Proceso SET Nombre='%s',Descripcion='%s',Dias_Vencimiento='%s'
					 WHERE ID_EstadoProceso= '%s'",
            
            mysql_real_escape_string($nombre),
            mysql_real_escape_string($descripcion),
			mysql_real_escape_string($dias_vencimiento),
			mysql_real_escape_string($id_estado)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}


//UPDATE Etapa

function updateEtapa($id_etapa,$id_asunto,$fecha_inicio,$descripcion,$id_estadoproceso)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Etapa SET FechaInicio='%s',Descripcion='%s'ID_EstadoProceso='%s'
					 WHERE ID_Etapa= '%s'",
            mysql_real_escape_string($fecha_inicio),
			mysql_real_escape_string($descripcion),
			mysql_real_escape_string($id_estadoproceso),
			mysql_real_escape_string($id_etapa)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

//UPDATE Pago

function updatePago($id_pago,$id_convenio,$id_asunto,$cantidad,$fecha)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Pago SET ID_Convenio='%s', ID_Asunto='%s',Cantidad='%s',Fecha='%s' WHERE ID_Pago= '%s'",
        	mysql_real_escape_string($id_convenio),
            mysql_real_escape_string($id_asunto),
			mysql_real_escape_string($cantidad),
            mysql_real_escape_string($fecha),
			mysql_real_escape_string($id_pago)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

//UPDATE Proceso

function updateProceso($id_proceso,$numeroetapas,$nombre,$descripcion)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Proceso SET ID_Proceso='%s', NumeroEtapas='%s', Nombre='%s',Descripcion='%s' WHERE ID_Proceso= '%s'",
        	mysql_real_escape_string($numeroetapas),
            mysql_real_escape_string($nombre),
			mysql_real_escape_string($descripcion),
            mysql_real_escape_string($id_proceso)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

//UPDATE TIPO MONEDA
function updateTipoMoneda($id_tipo_moneda,$nombre)
{
	$db = Database::obtain();
	
		$q = sprintf("UPDATE Tipo_Moneda SET Nombre='%s' WHERE ID_Tipo_Moneda='%s'",
            mysql_real_escape_string($nombre),
			mysql_real_escape_string($id_Tipo_Moneda)
			);
		
	$result = mysql_query($query) 
	or die(mysql_error());
	
	if($result=="1")
		return "Datos guardados correctamente.";
		else
		return $result;
}

/***********************************************************************
*
* 			METODOS SELECT PARA LAS TABLAS:  Abogado,Cliente,Asunto, Autoridad
*			CITA,Convenio,Dia no habil
*
************************************************************************/


//Metodo getAbogados

function getAbogados($columna,$filtro) {
//Conexión a la BD
$db = Database::obtain();
//Obtener información de la tabla
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Abogado";
else
	{
		switch($columna)
	{
		case "Nombre":
		$query = sprintf("SELECT * FROM Abogado WHERE Nombre LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
           // mysql_real_escape_string($columna),
		   break;
		case "ID_Abogado":
		 $query = sprintf("SELECT * FROM Abogado WHERE ID_Abogado LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Email":
		$query  = sprintf("SELECT * FROM Abogado WHERE Email LIKE '%%%s%%'",mysql_real_escape_string($filtro));
		break;
		case "EmailLogin":
		$query  = sprintf("SELECT * FROM Abogado WHERE Email='%s' ",mysql_real_escape_string($filtro));
		break;
		case "Direccion":
		$query  = sprintf("SELECT * FROM Abogado WHERE Direccion LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Telefono":
		$query = sprintf("SELECT * FROM Abogado WHERE Telefono LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Celular":
		$query = sprintf("SELECT * FROM Abogado WHERE Celular LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Nextel":
		$query = sprintf("SELECT * FROM Abogado WHERE Nextel LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
            
	}
	}


$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Abogado'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$toc[$i]['Email'] = $row[2];
				$toc[$i]['Password'] = $row[3];
				$toc[$i]['FechaN'] = $row[4];
				$toc[$i]['Direccion'] = $row[5];
				$toc[$i]['Telefono'] = $row[6];
				$toc[$i]['Celular'] = $row[7];
				$toc[$i]['Nextel'] = $row[8];
				$toc[$i]['Superusuario'] = $row[9];
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo

//Metodo Cliente
function getCliente($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Cliente";
else
	{
		switch($columna)
	{
		case "Nombre":
		$query = sprintf("SELECT * FROM Cliente WHERE Nombre LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Cliente":
		 $query = sprintf("SELECT * FROM Cliente WHERE ID_Cliente LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Email":
		$query  = sprintf("SELECT * FROM Cliente WHERE Email LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Direccion":
		$query  = sprintf("SELECT * FROM Cliente WHERE Direccion LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Telefono":
		$query = sprintf("SELECT * FROM Cliente WHERE Telefono LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Celular":
		$query = sprintf("SELECT * FROM Cliente WHERE Celular LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Nextel":
		$query = sprintf("SELECT * FROM Cliente WHERE Nextel LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;            
	}
	}


$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Cliente'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$toc[$i]['Email'] = $row[2];
				$toc[$i]['FechaN'] = $row[3];
				$toc[$i]['Direccion'] = $row[4];
				$toc[$i]['Telefono'] = $row[5];
				$toc[$i]['Celular'] = $row[6];
				$toc[$i]['Nextel'] = $row[7];
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo

		
	
//Metodo Archivo
function getArchivo($columna,$filtro) {

$db = Database::obtain();

if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Archivo";
else
	{
		switch($columna)
	{
		case "ID_Archivo":
		$query = sprintf("SELECT * FROM Archivo WHERE ID_Archivo  LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Etapa":
		$query = sprintf("SELECT * FROM Archivo WHERE ID_Etapa LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Asunto":
		$query = sprintf("SELECT * FROM Archivo WHERE ID_Asunto LIKE '%%%s%%'",mysql_real_escape_string($filtro));
         	   break;
		case "Nombre":
		$query = sprintf("SELECT * FROM Archivo WHERE Nombre LIKE '%%%s%%'",mysql_real_escape_string($filtro));
         	   break;
		case "Ruta":
		$query = sprintf("SELECT * FROM Archivo WHERE Ruta  LIKE '%%%s%%'",mysql_real_escape_string($filtro));
         	   break;
	}
	}//corchete?

$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Archivo'] = $row[0];
				$toc[$i]['ID_Etapa'] = $row[1];
				$toc[$i]['ID_Archivo'] = $row[2];
				$toc[$i]['Descripcion'] = $row[3];
				$toc[$i]['Nombre'] = $row[4];
				$toc[$i]['Ruta'] = $row[5];
				$toc[$i]['Tamano'] = $row[6];	
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo


		
	
//Metodo Asunto
function getAsunto($columna,$filtro) {

$db = Database::obtain();

if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Asunto";
else
	{
		switch($columna)
	{
		case "ID_Asunto":
		$query = sprintf("SELECT * FROM Asunto WHERE ID_Asunto  LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Estado":
		$query = sprintf("SELECT * FROM Asunto WHERE ID_Estado LIKE '%%%s%%'' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Cliente":
		$query = sprintf("SELECT * FROM Asunto WHERE ID_Cliente LIKE '%%%s%%'",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Abogado":
		$query = sprintf("SELECT * FROM Asunto WHERE ID_Abogado LIKE '%%%s%%'",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Proceso":
		$query = sprintf("SELECT * FROM Asunto WHERE ID_Proceso  LIKE '%%%s%%'",mysql_real_escape_string($filtro));
         	   break;
	    case "ID_Autoridad":
		$query = sprintf("SELECT * FROM Asunto WHERE ID_Autoridad  LIKE '%%%s%%'",mysql_real_escape_string($filtro));
         	   break;

	}
	}//corchete?

$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Asunto'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$toc[$i]['Descripcion'] = $row[2];
				$toc[$i]['Fecha_inicio'] = $row[3];
				$toc[$i]['Fecha_fin'] = $row[4];
				$toc[$i]['ID_Estado'] = $row[5];
				$toc[$i]['ID_Proceso'] = $row[6];				
				$toc[$i]['ID_Autoridad'] = $row[7];
				$toc[$i]['ID_Cliente'] = $row[8];
				$toc[$i]['ID_Abogado'] = $row[9];
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo



	
//Metodo Asunto2
function getAsunto2($columna, $filtro1, $filtro2) {

$db = Database::obtain();

if($columna=="ID_Abogado")
	$query = "SELECT * FROM Asunto WHERE ID_Abogado=".$filtro1." AND ID_Estado=".$filtro2." ";
else if($columna=="ID_Cliente")
	$query = "SELECT * FROM Asunto WHERE ID_Cliente=".$filtro1." AND ID_Estado=".$filtro2." ";

$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Asunto'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$toc[$i]['Descripcion'] = $row[2];
				$toc[$i]['Fecha_inicio'] = $row[3];
				$toc[$i]['Fecha_fin'] = $row[4];
				$toc[$i]['ID_Estado'] = $row[5];
				$toc[$i]['ID_Proceso'] = $row[6];				
				$toc[$i]['ID_Autoridad'] = $row[7];
				$toc[$i]['ID_Cliente'] = $row[8];
				$toc[$i]['ID_Abogado'] = $row[9];
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo


//Metodo Autoridad
function getAutoridad($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Autoridad";
else
	{
 switch($columna)
	{
		case "ID_Autoridad":
		$query = sprintf("SELECT * FROM Autoridad WHERE ID_Autoridad LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Asunto":
		$query = sprintf("SELECT * FROM Autoridad WHERE ID_Asunto LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
	} ///corchete?
	
	}

$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Autoridad'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$toc[$i]['Descripcion'] = $row[2];
				$toc[$i]['Telefono'] = $row[3];
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo



//Metodo Cita
function getCita($columna,$filtro) {
//Conexión a la BD
$db = Database::obtain();
//Obtener información de la tabla
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Cita";
else
	{
		switch($columna)
	{
		case "ID_Cliente":
		$query = sprintf("SELECT * FROM Cita WHERE ID_Cliente LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
           // mysql_real_escape_string($columna),
		   break;
		case "ID_Abogado":
		 $query = sprintf("SELECT * FROM Cita WHERE ID_Abogado LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "ID_Asunto":
		$query  = sprintf("SELECT * FROM Cita WHERE ID_Asunto LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
		case "Lugar":
		$query  = sprintf("SELECT * FROM Cita WHERE Lugar LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
		break;
            
	}
	}


$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Cita'] = $row[0];
				$toc[$i]['ID_Cliente'] = $row[1];
				$toc[$i]['ID_Asunto'] = $row[2];
				$toc[$i]['ID_Abogado'] = $row[3];
				$toc[$i]['Lugar'] = $row[4];
				$toc[$i]['Fecha'] = $row[5];
				$toc[$i]['Hora'] = $row[6];	
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo



//Metodo Convenio

function getConvenio($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Convenio";
else
	{
		switch($columna)
	{
		case "ID_Asunto":
		$query = sprintf("SELECT * FROM Convenio WHERE ID_Asunto LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Tipo_Moneda":
		$query = sprintf("SELECT * FROM Convenio WHERE ID_Tipo_Moneda LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
	}
	}
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Convenio'] = $row[0];
				$toc[$i]['ID_Asunto'] = $row[1];
				$toc[$i]['Cantidad'] = $row[2];
				$toc[$i]['Descripcion'] = $row[3];
				$toc[$i]['ID_Tipo_Moneda'] = $row[4];
				$i++;
			}
			//Retorna 
			return $toc;
} //Fin metodo


//Metodo Dia no habil
function getDiaNoHabil($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Dias_No_Habiles";
else
	{
	switch($columna)
	{
		case "ID_DiaNoHabil":
		$query = sprintf("SELECT * FROM Dias_No_Habiles WHERE ID_DiaNoHabil LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Dia":
		$query = sprintf("SELECT * FROM Dias_No_Habiles WHERE Dia LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_DiaNoHabil":
		$query = sprintf("SELECT * FROM Dias_No_Habiles WHERE ID_DiaNoHabil LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Year":
		$query = sprintf("SELECT * FROM Dias_No_Habiles WHERE YEAR(Dia) LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Month":
		$query = sprintf("SELECT * FROM Dias_No_Habiles WHERE MONTH(Dia) LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Day":
		$query = sprintf("SELECT * FROM Dias_No_Habiles WHERE DAY(Dia) LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
	}
	}
	
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_DiaNoHabil'] = $row[0];
				$toc[$i]['Dia'] = $row[1];
				$i++;
			}
			return $toc;
}


//Metodo Estado_Asunto

function getEstadoAsunto($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Estado_Asunto";
else
	{
		switch($columna)
	{
		case "ID_Estado":
		$query = sprintf("SELECT * FROM Estado_Asunto WHERE ID_Estado LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Nombre":
		$query = sprintf("SELECT * FROM Estado_Asunto WHERE Nombre LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
	}
	}
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Estado'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$toc[$i]['Descripcion'] = $row[2];
				$i++;
			}
			//Retorna 
			return $toc;
} 

//Metodo Estado_Proceso

function getEstadoProceso($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Estado_Proceso";
else
	{
		switch($columna)
	{
		case "ID_EstadoProceso":
		$query = sprintf("SELECT * FROM Estado_Proceso WHERE ID_EstadoProceso LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Nombre":
		$query = sprintf("SELECT * FROM Estado_Proceso WHERE Nombre LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
			   case "ID_Asunto":
		$query = sprintf("select * from Estado_Proceso e where e.ID_EstadoProceso not in (Select ID_EstadoProceso FROM Etapa Where ID_Asunto='%s');",mysql_real_escape_string($filtro));
         	   break;
			   }
	}
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_EstadoProceso'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$toc[$i]['Descripcion'] = $row[2];
				$toc[$i]['Dias_Vencimiento'] = $row[3];
				$i++;
			}
			//Retorna 
			return $toc;
} 



//Metodo Etapa
function getEtapa($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Etapa";
else
	{
		switch($columna)
	{
		case "ID_Etapa":
		$query = sprintf("SELECT * FROM Etapa WHERE ID_Etapa LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Asunto":
		$query = sprintf("SELECT * FROM Etapa WHERE ID_Asunto LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Nombre":
		$query = sprintf("SELECT * FROM Etapa WHERE Nombre LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_EstadoProceso":
		$query = sprintf("SELECT * FROM Etapa WHERE ID_EstadoProceso LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
	}
	}
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Etapa'] = $row[0];
				$toc[$i]['ID_Asunto'] = $row[1];
				$toc[$i]['Fecha_Inicio'] = $row[2];
				$toc[$i]['Descripcion'] = $row[3];
				$toc[$i]['ID_EstadoProceso'] = $row[4];
				$i++;
			}
			//Retorna 
			return $toc;
} 


//Metodo Pagos
function getPago($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Pago";
else
	{
		switch($columna)
	{
		case "ID_Asunto":
		$query = sprintf("SELECT * FROM Pago WHERE ID_Asunto LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "ID_Convenio":
		$query = sprintf("SELECT * FROM Pago WHERE ID_Convenio LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
	}
	}
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Pago'] = $row[0];
				$toc[$i]['ID_Convenio'] = $row[1];
				$toc[$i]['ID_Asunto'] = $row[2];
				$toc[$i]['Cantidad'] = $row[3];
				$toc[$i]['Fecha'] = $row[4];
				$i++;
			}
			//Retorna 
			return $toc;
} 

//Metodo Proceso
function getProceso($columna,$filtro) {

$db = Database::obtain();
if($filtro=="" || $columna=="")
	$query = "SELECT * FROM Proceso";
else
	{
		switch($columna)
	{
		case "ID_Proceso":
		$query = sprintf("SELECT * FROM Proceso WHERE ID_Proceso LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Nombre":
		$query = sprintf("SELECT * FROM Proceso WHERE Nombre LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "NumeroEtapas":
		$query = sprintf("SELECT * FROM Proceso WHERE NumeroEtapas LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
		case "Descripcion":
		$query = sprintf("SELECT * FROM Proceso WHERE Descripcion LIKE '%%%s%%' ",mysql_real_escape_string($filtro));
         	   break;
	}
	}
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Proceso'] = $row[0];
				$toc[$i]['NumeroEtapas'] = $row[1];
				$toc[$i]['Nombre'] = $row[2];
				$toc[$i]['Descripcion'] = $row[3];
				$i++;
			}
			//Retorna 
			return $toc;
} 

//Metodo Tipo Moneda
function getTipoMoneda() {
$db = Database::obtain();
$query = "SELECT * FROM Tipo_Moneda";
$result = mysql_query($query)
or die(mysql_error()); 
$i = 0;
//Guardar arreglo de los objetos de la tabla
	
while($row= mysql_fetch_row($result))
			{
				$toc[$i]['ID_Tipo_Moneda'] = $row[0];
				$toc[$i]['Nombre'] = $row[1];
				$i++;
			}
			return $toc;
}


/*******************************************************************
*
* 			REGISTRO DE ARRAYS Y ESTRUCTURA (CLASES)
*
*
********************************************************************/

// Abogado
$server->wsdl->addComplexType(
	'ArregloAbogados', 			// Nombre
	'complexType', 					// Tipo de Clase
	'array', 						// Tipo de PHP
	'', 							// definición del tipo secuencia(all|sequence|choice)
	'SOAP-ENC:Array', 				// Restricted Base
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Abogados[]') // Atributos
	),
	'tns:Abogados'
);
           
		   
//Definición de estructura de datos
			
$server->wsdl->addComplexType('Abogados', 'complexType', 'struct', 'all', '',
    array(
		'ID_Abogado'=> array('name' => 'ID_Abogado','type' => 'xsd:int'),
		'Nombre'    => array('name' => 'Nombre',    'type' => 'xsd:string'),
		'Email'    => array('name' => 'Email',    'type' => 'xsd:string'),
		'Password'  => array('name' => 'Password', 'type' => 'xsd:string'),
		'FechaN' => array('name' => 'FechaN', 'type' => 'xsd:date'),
		'Direccion' => array('name' => 'Direccion', 'type' => 'xsd:string'),
		'Telefono' => array( 'name' => 'Telefono' , 'type' => 'xsd:string'),
		'Celular' => array( 'name' => 'Celular' , 'type' => 'xsd:string'),
		'Nextel' => array( 'name' => 'Nextel' , 'type' => 'xsd:string'),
		'Superusuario' => array('name'=>'Superusuario','type'=>'xsd:boolean')
    )
);			

// Cliente
$server->wsdl->addComplexType(
	'ArregloClientes', 			// Nombre
	'complexType', 					// Tipo de Clase
	'array', 						// Tipo de PHP
	'', 							// definición del tipo secuencia(all|sequence|choice)
	'SOAP-ENC:Array', 				// Restricted Base
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Clientes[]') // Atributos
	),
	'tns:Clientes'
);
           
		   
//Definición de estructura de datos
			
$server->wsdl->addComplexType('Clientes', 'complexType', 'struct', 'all', '',
    array(
		'ID_Cliente'=> array('name' => 'ID_Cliente','type' => 'xsd:int'),
		'Nombre'    => array('name' => 'Nombre',    'type' => 'xsd:string'),
		'Email'    => array('name' => 'Email',    'type' => 'xsd:string'),
		'FechaN' => array('name' => 'FechaN', 'type' => 'xsd:date'),
		'Direccion' => array('name' => 'Direccion', 'type' => 'xsd:string'),
		'Telefono' => array( 'name' => 'Telefono' , 'type' => 'xsd:string'),
		'Celular' => array( 'name' => 'Celular' , 'type' => 'xsd:string'),
		'Nextel' => array( 'name' => 'Nextel' , 'type' => 'xsd:string')
    )
);			


// Asunto
$server->wsdl->addComplexType(
	'ArregloAsuntos', 			// Nombre
	'complexType', 					// Tipo de Clase
	'array', 						// Tipo de PHP
	'', 							// definición del tipo secuencia(all|sequence|choice)
	'SOAP-ENC:Array', 				// Restricted Base
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Asuntos[]') // Atributos
	),
	'tns:Asuntos'
);
           
		   
//Definición de estructura de datos
			
$server->wsdl->addComplexType('Asuntos', 'complexType', 'struct', 'all', '',
    array(
		'ID_Asunto'=> array('name' => 'ID_Asunto','type' => 'xsd:int'),
		'Nombre'    => array('name' => 'Nombre',    'type' => 'xsd:string'),
		'Descripcion'    => array('name' => 'Descripcion',    'type' => 'xsd:string'),
		'Fecha_inicio'  => array('name' => 'Fecha_inicio', 'type' => 'xsd:date'),
		'Fecha_fin' => array('name' => 'Fecha_fin', 'type' => 'xsd:date'),
		'ID_Estado' => array('name' => 'ID_Estado', 'type' => 'xsd:int'),
		'ID_Proceso' => array( 'name' => 'ID_Proceso' , 'type' => 'xsd:int'),
		'ID_Autoridad' => array( 'name' => 'ID_Autoridad' , 'type' => 'xsd:int'),		
		'ID_Cliente' => array( 'name' => 'ID_Cliente' , 'type' => 'xsd:int'),
		'ID_Abogado' => array( 'name' => 'ID_Abogado' , 'type' => 'xsd:int')
	    )
);			

//Definición de estructura de datos Archivo
			
			
$server->wsdl->addComplexType(
	'ArregloArchivo', 			// Nombre
	'complexType', 					// Tipo de Clase
	'array', 						// Tipo de PHP
	'', 							// definición del tipo secuencia(all|sequence|choice)
	'SOAP-ENC:Array', 				// Restricted Base
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Archivo[]') // Atributos
	),
	'tns:Archivo'
);

$server->wsdl->addComplexType('Archivo', 'complexType', 'struct', 'all', '',
    array(
		'ID_Archivo'=> array('name' => 'ID_Archivo','type' => 'xsd:int'),
		'ID_Etapa'=> array('name' => 'ID_Etapa','type' => 'xsd:int'),
		'ID_Asunto'=> array('name' => 'ID_Asunto','type' => 'xsd:int'),

		'Descripcion'    => array('name' => 'Descripcion',    'type' => 'xsd:string'),
		'Nombre'    => array('name' => 'Nombre',    'type' => 'xsd:string'),
		'Ruta'  => array('name' => 'Ruta', 'type' => 'xsd:string'),
		'Tamano'  => array('name' => 'Tamano', 'type' => 'xsd:string')
	    )
);			

//Definición de estructura de datos Autoridad
			
			
$server->wsdl->addComplexType(
	'ArregloAutoridad', 			// Nombre
	'complexType', 					// Tipo de Clase
	'array', 						// Tipo de PHP
	'', 							// definición del tipo secuencia(all|sequence|choice)
	'SOAP-ENC:Array', 				// Restricted Base
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Autoridad[]') // Atributos
	),
	'tns:Autoridad'
);

$server->wsdl->addComplexType('Autoridad', 'complexType', 'struct', 'all', '',
    array(
		'ID_Autoridad'=> array('name' => 'ID_Autoridad','type' => 'xsd:int'),
		'Nombre'    => array('name' => 'Nombre',    'type' => 'xsd:string'),
		'Descripcion'    => array('name' => 'Descripcion',    'type' => 'xsd:string'),
		'Telefono'  => array('name' => 'Telefono', 'type' => 'xsd:string')
	    )
);			



//Definición de estructura de datos Cita	
			
$server->wsdl->addComplexType(
	'ArregloCita', 			// Nombre
	'complexType', 					// Tipo de Clase
	'array', 						// Tipo de PHP
	'', 							// definición del tipo secuencia(all|sequence|choice)
	'SOAP-ENC:Array', 				// Restricted Base
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Cita[]') // Atributos
	),
	'tns:Cita'
);

$server->wsdl->addComplexType('Cita', 'complexType', 'struct', 'all', '',
    array(
		'ID_Cita'=> array('name' => 'ID_Cita','type' => 'xsd:int'),
		'ID_Cliente'=> array('name' => 'ID_Cliente','type' => 'xsd:int'),
				'ID_Asunto'=> array('name' => 'ID_Asunto','type' => 'xsd:int'),
		'ID_Abogado'=> array('name' => 'ID_Abogado','type' => 'xsd:int'),
		'Lugar'=> array ( 'name'=> 'Lugar', 'type'=> 'xsd:string'),
		'Fecha'=> array ( 'name'=> 'Fecha', 'type'=> 'xsd:date'),
		'Hora'=> array('name'=>'Hora', 'type'=> 'xsd:date')
	    )
);			


//Definición de estructura de datos Convenio	
			
$server->wsdl->addComplexType(
	'ArregloConvenio', 			// Nombre
	'complexType', 					// Tipo de Clase
	'array', 						// Tipo de PHP
	'', 							// definición del tipo secuencia(all|sequence|choice)
	'SOAP-ENC:Array', 				// Restricted Base
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Convenio[]') 
	),
	'tns:Convenio'
);

$server->wsdl->addComplexType('Convenio', 'complexType', 'struct', 'all', '',
    array(
		'ID_Convenio'=> array('name' => 'ID_Convenio','type' => 'xsd:int'),
		'ID_Asunto'=> array('name' => 'ID_Asunto','type' => 'xsd:int'),
		'Cantidad'=> array('name' => 'Cantidad','type' => 'xsd:double'),
		'Descripcion'=> array('name' => 'Descripcion','type' => 'xsd:string'),
		'ID_Tipo_Moneda'=> array ( 'name'=> 'ID_Tipo_Moneda', 'type'=> 'xsd:int')	    )
);			



//Definición de estructura de datos Dia no habil	
			
$server->wsdl->addComplexType(
	'ArregloDiaNoHabil', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:DiaNoHabil[]') 
	),
	'tns:DiaNoHabil'
);

$server->wsdl->addComplexType('DiaNoHabil', 'complexType', 'struct', 'all', '',
    array(
		'ID_DiaNoHabil'=> array('name' => 'ID_DiaNoHabil','type' => 'xsd:int'),
		'Dia'=> array('name' => 'Dia','type' => 'xsd:date')
		)
);			



//Definición de estructura de datos Dias no habiles	
			
$server->wsdl->addComplexType(
	'ArregloDiaNoHabil', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:DiaNoHabil[]') 
	),
	'tns:DiaNoHabil'
);

$server->wsdl->addComplexType('DiaNoHabil', 'complexType', 'struct', 'all', '',
    array(
		'ID_DiaNoHabil'=> array('name' => 'ID_DiaNoHabil','type' => 'xsd:int'),
		'Dia'=> array('name' => 'Dia','type' => 'xsd:date')
		)
);			



//Definición de estructura de datos Estado Asunto
			
$server->wsdl->addComplexType(
	'ArregloEstadoAsunto', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:EstadoAsunto[]') 
	),
	'tns:EstadoAsunto'
);

$server->wsdl->addComplexType('EstadoAsunto', 'complexType', 'struct', 'all', '',
    array(
		'ID_Estado'=> array('name' => 'ID_Estado','type' => 'xsd:int'),
		'Nombre'=> array('name' => 'Nombre','type' => 'xsd:string'),
		'Descripcion'=> array('name' => 'Descripcion','type' => 'xsd:string'),
		)
);			

//Definición de estructura de datos Estado Proceso
			
$server->wsdl->addComplexType(
	'ArregloEstadoProceso', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:EstadoProceso[]') 
	),
	'tns:EstadoProceso'
);

$server->wsdl->addComplexType('EstadoProceso', 'complexType', 'struct', 'all', '',
    array(
		'ID_EstadoProceso'=> array('name' => 'ID_EstadoProceso','type' => 'xsd:int'),
		'Nombre'=> array('name' => 'Nombre','type' => 'xsd:string'),
		'Descripcion'=> array('name' => 'Descripcion','type' => 'xsd:string'),
		'Dias_Vencimiento'=>array ( 'name' => 'Dias_Vencimiento','type'=>'xsd:int')
		)
);			


//Definición de estructura de datos Etapa
			
$server->wsdl->addComplexType(
	'ArregloEtapa', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Etapa[]') 
	),
	'tns:Etapa'
);

$server->wsdl->addComplexType('Etapa', 'complexType', 'struct', 'all', '',
    array(
		'ID_Etapa'=> array('name' => 'ID_Etapa','type' => 'xsd:int'),
		'ID_Asunto'=> array('name' => 'ID_Asunto','type' => 'xsd:int'),
		'Fecha_Inicio' => array ('name'=> 'Fecha_Inicio','type'=> 'xsd:date'),
		'Descripcion'=> array('name' => 'Descripcion','type' => 'xsd:string'),
		'ID_EstadoProceso'=>array ( 'name' => 'ID_EstadoProceso','type'=>'xsd:int')
		)
);			


//Definición de estructura de datos Pagos
			
$server->wsdl->addComplexType(
	'ArregloPago', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Pago[]') 
	),
	'tns:Pago'
);

$server->wsdl->addComplexType('Pago', 'complexType', 'struct', 'all', '',
    array(
		'ID_Pago'=> array('name' => 'ID_Pago','type' => 'xsd:int'),
		'ID_Convenio'=> array('name' => 'ID_Convenio','type' => 'xsd:int'),
		'ID_Asunto'=> array('name' => 'ID_Asunto','type' => 'xsd:int'),
		'Cantidad'=> array('name' => 'Cantidad','type' => 'xsd:double'),
		'Fecha' => array ('name'=> 'Fecha','type'=> 'xsd:date')
		)
);			


//Definición de estructura de datos Proceso
			
$server->wsdl->addComplexType(
	'ArregloProceso', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		array('ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:Proceso[]') 
	),
	'tns:Proceso'
);

$server->wsdl->addComplexType('Proceso', 'complexType', 'struct', 'all', '',
    array(
		'ID_Proceso'=> array('name' => 'ID_Proceso','type' => 'xsd:int'),
		'NumeroEtapas'=> array('name' => 'NumeroEtapas','type' => 'xsd:int'),
		'Nombre'=> array('name' => 'Nombre','type' => 'xsd:string'),
		'Descripcion'=> array('name' => 'Descripcion','type' => 'xsd:string')
		)
);			


//Definición de estructura de datos Tipo Moneda
			
$server->wsdl->addComplexType(
	'ArregloTipoMoneda', 			
	'complexType', 				
	'array', 					
	'', 		
	'SOAP-ENC:Array', 				
	array(),
	array(
		 array( 
			   'ref' => 'SOAP-ENC:arrayType', 'wsdl:arrayType' => 'tns:TipoMoneda[]'
			   ) 
		 ),
	'tns:TipoMoneda'
);

$server->wsdl->addComplexType('TipoMoneda', 'complexType', 'struct', 'all', '',
    array(
		'ID_Tipo_Moneda'=> array('name' => 'ID_Tipo_Moneda','type' => 'xsd:int'),
		'Nombre'=> array('name' => 'Nombre','type' => 'xsd:string')
		)
);			

/*******************************************************************
*
* 			REGISTRO DE  METODOS EN GENERAL
*
*
********************************************************************/

#Abogados

//registro de metodo addAbogados
$server->register(
				  'addAbogados', 					//Nombre del metodo
				  array('nombre' => 'xsd:string',	//Parametros de entrada
						'email'=> 'xsd:string',
						'password'=> 'xsd:string',
						'fechan' => 'xsd:date',
						'direccion'=> 'xsd:string',
						'telefono'=> 'xsd:string',
						'celular' => 'xsd:string',
						'nextel'=> 'xsd:string',
						'superusuario'=>'xsd:boolean'
						),
				  array('return' => 'xsd:string')		//Datos de salida	
				  );
				  
//registro de metodo updateAbogados
$server->register(
				  	'updateAbogados',			//Nombre del metodo
				  array('id_abogado' => 'xsd:string',
						'nombre' => 'xsd:string',	//Parametros de entrada
						'email'=> 'xsd:string',
						'password' => 'xsd:string',
						'fechan' => 'xsd:date',
						'direccion'=> 'xsd:string',
						'telefono'=> 'xsd:string',
						'celular' => 'xsd:string',
						'nextel'=> 'xsd:string',
						'superusuario'=> 'xsd:boolean'
						),
			
				  array('return' => 'xsd:string')		//Datos de salida	
				  );

//registro de metodo getAbogados
$server->register(
	'getAbogados',   						// Nombre del Método
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         // Parámetros de Entrada
    array('return' => 'tns:ArregloAbogados')   //Datos de Salida
);

//registro de metodo deleteAbogados
$server->register(
	'deleteAbogados',   						// Nombre del Método
    array('id_abogado' => 'xsd:string'),         // Parámetros de Entrada
    array('return' => 'xsd:string')   //Datos de Salida
);

//registro de método login
$server->register(
	'login',   						// Nombre del Método
    array('email'=> 'xsd:string', 'password'=>'xsd:string'),         // Parámetros de Entrada
    array('return' => 'xsd:boolean')   //Datos de Salida
);


#Cliente

//registro de metodo addCliente
$server->register(
				  'addCliente', 				
				  array('nombre' => 'xsd:string',	
						'email'=> 'xsd:string',
						'fechan' => 'xsd:date',
						'direccion'=> 'xsd:string',
						'telefono'=> 'xsd:string',
						'celular' => 'xsd:string',
						'nextel'=> 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateCliente
$server->register(
				  	'updateCliente',			
				  array('id_cliente' => 'xsd:string',
						'nombre' => 'xsd:string',	
						'email'=> 'xsd:string',
						'fechan' => 'xsd:date',
						'direccion'=> 'xsd:string',
						'telefono'=> 'xsd:string',
						'celular' => 'xsd:string',
						'nextel'=> 'xsd:string'),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getCliente
$server->register(
	'getCliente',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloClientes')  
);

//registro de metodo deleteCliente
$server->register(
	'deleteCliente',   						
    array('id_cliente' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);


#Asunto

//registro de metodo addAsunto
$server->register(
				  'addAsunto', 				
				  array('nombre' => 'xsd:string',	
						'descripcion'=> 'xsd:string',
						'fechainicio' => 'xsd:date',
						'fechafin'=> 'xsd:date',
						'id_estado'=> 'xsd:int',
						'id_proceso'=> 'xsd:int',
						'id_autoridad'=>'xsd:int',
						'id_cliente'=>'xsd:int',
						'id_abogado'=>'xsd:int'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateAsunto
$server->register(
				  	'updateAsunto',			
				  array('id_asunto' => 'xsd:string',
						'nombre' => 'xsd:string',
						'descripcion'=>'xsd:string',
						'fechainicio' => 'xsd:date',
						'fechafin'=> 'xsd:date',
						'id_estado'=> 'xsd:int',
						'id_proceso'=> 'xsd:int',
						'id_autoridad'=>'xsd:int',
						'id_cliente'=>'xsd:int',
						'id_abogado'=>'xsd:int'
						),
				  array('return' => 'xsd:string')		
				  );


//registro de metodo addAchivo
$server->register(
				  'addArchivo', 				
				  array('id_etapa' => 'xsd:int',	
						'id_asunto'=> 'xsd:int',
						'descripcion' => 'xsd:string',
						'nombre'=> 'xsd:string',
						'ruta'=> 'xsd:string',
						'tamano'=> 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo deleteArchivo
$server->register(
	'deleteArchivo',   						
    array('id_archivo' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);

				  
//registro de metodo getaArchivo
$server->register(
	'getArchivo',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloArchivo')  
);

//registro de metodo updateArchivo
/*$server->register(
				  	'updateArchivo',			
				  array('id_asunto' => 'xsd:int',
						'id_etapa' => 'xsd:int',	
						'id_asunto'=> 'xsd:int',
						'descripcion' => 'xsd:string',
						'nombre'=> 'xsd:string',
						'ruta'=> 'xsd:string',
						'tamano'=> 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );
*/

$server->register(
	'getAsunto',   						
    array('columna' => 'xsd:string'  ,
		  'filtro1'=> 'xsd:string'),
    array('return' => 'tns:ArregloAsuntos')  
);
$server->register(
	'getAsunto2',   						
    array('columna' => 'xsd:string'  ,
		  'filtro1'=> 'xsd:string',  
		'filtro2'=> 'xsd:string'),
    array('return' => 'tns:ArregloAsuntos')  
);

//registro de metodo deleteAsunto
$server->register(
	'deleteAsunto',   						
    array('id_asunto' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);


#Autoridad

//registro de metodo addAutoridad
$server->register(
				  'addAutoridad', 				
				  array('nombre' => 'xsd:string',	
						'descripcion'=> 'xsd:string',
						'telefono' => 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateAutoridad
$server->register(
				  	'updateAutoridad',			
				  array('id_asunto' => 'xsd:string',
						'nombre' => 'xsd:string',
						'nombre' => 'xsd:string',	
						'descripcion'=> 'xsd:string',
						'telefono' => 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getAutoridad
$server->register(
	'getAutoridad',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloAutoridad')  
);

//registro de metodo deleteAutoridad
$server->register(
	'deleteAutoridad',   						
    array('id_autoridad' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);


#Cita

//registro de metodo addCita
$server->register(
				  'addCita', 				
				  array(
						'id_cliente'=> 'xsd:int',
						'id_asunto'=> 'xsd:int',
						'id_abogado'=>'xsd:int',
						'lugar'=>'xsd:string',
						'fecha'=>'xsd:date',
						'hora'=> 'xsd:time'						
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateCita
$server->register(
				  	'updateCita',			
				  array('id_cita' => 'xsd:int',
						'id_cliente'=> 'xsd:int',
						'id_asunto'=> 'xsd:int',
						'id_abogado'=>'xsd:int',
						'lugar'=>'xsd:string',
						'fecha'=>'xsd:date',
						'hora'=> 'xsd:time'						
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getCita
$server->register(
	'getCita',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloCita')  
);

//registro de metodo deleteAsunto
$server->register(
	'deleteCita',   						
    array('id_cita' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);


#Convenio
//registro de metodo addConvenio
$server->register(
				  'addConvenio', 				
				  array(
						'id_asunto'=> 'xsd:int',
						'cantidad'=> 'xsd:double',
						'descripcion'=>'xsd:string',
						'id_tipo_moneda'=>'xsd:int'			
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateConvenio
$server->register(
				  	'updateConvenio',			
				  array(
						'id_convenio' => 'xsd:int',
						'id_asunto'=> 'xsd:int',
						'cantidad'=> 'xsd:double',
						'descripcion'=>'xsd:string',
						'id_tipo_moneda'=>'xsd:int'			
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getConvenio
$server->register(
	'getConvenio',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloConvenio')  
);

//registro de metodo deleteConvenio
$server->register(
	'deleteConvenio',   						
    array('id_convenio' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);


#Dias no habiles

//registro de metodo addDiaNoHabil
$server->register(
				  'addDiaNoHabil', 				
				  array('dia' => 'xsd:date'),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateDiaNoHabil
$server->register(
				  	'updateDiaNoHabil',			
				  array('id_dianohabil' => 'xsd:int',
						'dia' => 'xsd:date'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getDiaNoHabil
$server->register(
	'getDiaNoHabil',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloDiaNoHabil')  
);

//registro de metodo deleteDiaNoHabil
$server->register(
	'deleteDiaNoHabil',   						
    array('id_dianohabil' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);

#Asunto_Estado

//registro de metodo addEstadoAsunto
$server->register(
				  'addEstadoAsunto', 				
				  array(
						'Nombre' => 'xsd:string',
						'Descripcion'=> 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateEstadoAsunto
$server->register(
				  	'updateEstadoAsunto',			
				  array('id_estado' => 'xsd:int',
						'nombre' => 'xsd:string',
						'descripcion'=> 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getEstadoAsunto
$server->register(
	'getEstadoAsunto',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloEstadoAsunto')  
);

//registro de metodo deleteEstadoAsunto
$server->register(
	'deleteEstadoAsunto',   						
    array('id_estado' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);


#Proceso_Estado

//registro de metodo addEstadoProceso
$server->register(
				  'addEstadoProceso', 				
				  array(
						'nombre' => 'xsd:string',
						'descripcion'=> 'xsd:string',
						'dias_vencimiento'=>'xsd:int'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateEstadoProceso
$server->register( 	'updateEstadoProceso',			
				  array('id_estado' => 'xsd:int',
						'nombre' => 'xsd:string',
						'descripcion'=> 'xsd:string',
						'dias_vencimiento'=>'xsd:int'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getEstadoProceso
$server->register(
	'getEstadoProceso',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloEstadoProceso')  
);

//registro de metodo deleteEstadoProceso
$server->register(
	'deleteEstadoProceso',   						
    array('id_estado' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);


#Etapa

//registro de metodo addEtapa
$server->register(
				  'addEtapa', 				
				  array(
						'id_asunto'=>'xsd:int',		
						'fecha_inicio' => 'xsd:date',
						'descripcion'=> 'xsd:string',
						'id_estadoproceso'=>'xsd:int'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateEtapa
$server->register(
				  	'updateEtapa',			
				  array('id_etapa' => 'xsd:int',
						'id_asunto'=>'xsd:int',		
						'fecha_inicio' => 'xsd:date',
						'descripcion'=> 'xsd:string',
						'id_estadoproceso'=>'xsd:int'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getEtapa
$server->register(
	'getEtapa',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloEtapa')  
);

//registro de metodo deleteEtapa
$server->register(
	'deleteEtapa',   						
    array('id_etapa' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);

#Pago

//registro de metodo addPago
$server->register(
				  'addPago', 				
				  array(
						'id_convenio'=>'xsd:int',						
						'id_asunto' => 'xsd:int',
						'cantidad' => 'xsd:double',
						'fecha'=> 'xsd:date'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updatePago
$server->register(
				  	'updatePago',			
				  array('id_pago' => 'xsd:int',
						'id_convenio'=>'xsd:int',						
						'id_asunto' => 'xsd:int',
						'cantidad' => 'xsd:double',
						'fecha'=> 'xsd:date'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getPago
$server->register(
	'getPago',   						
    array('columna' => 'xsd:string'  , 'filtro'=> 'xsd:string'),         
    array('return' => 'tns:ArregloPago')  
);

//registro de metodo deletePago
$server->register(
	'deletePago',   						
    array('id_pago' => 'xsd:string'),         
    array('return' => 'xsd:string')   
);

#Proceso

//registro de metodo addProceso
$server->register(
				  'addProceso', 				
				  array(
						'numeroetapas'=>'xsd:int',						
						'nombre' => 'xsd:string',
					'descripcion' => 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateProceso
$server->register(
				  	'updateProceso',			
				  array('id_proceso' => 'xsd:int',
						'numeroetapas'=>'xsd:int',						
						'nombre' => 'xsd:string',
					'descripcion' => 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getProceso
$server->register(	'getProceso',   
				  array('columna' => 'xsd:string' , 'filtro'=> 'xsd:string'),         
   				 array('return' => 'tns:ArregloProceso')  
);

//registro de metodo deleteProceso
$server->register(
	'deleteProceso',   						
    array('id_proceso' => 'xsd:int'),         
    array('return' => 'xsd:string')   
);

#Tipo Moneda

//registro de metodo addTipoMoneda
$server->register(
				  'addTipoMoneda', 				
				  array('nombre' => 'xsd:string'),
				  array('return' => 'xsd:string')		
				  );
				  
//registro de metodo updateTipoMoneda
$server->register(
				  	'updateTipoMoneda',			
				  array('id_tipo_moneda' => 'xsd:int',
						'nombre' => 'xsd:string'
						),
				  array('return' => 'xsd:string')		
				  );

//registro de metodo getTipoMoneda
$server->register(
	'getTipoMoneda',   						
    array(),         
    array('return' => 'tns:ArregloTipoMoneda')  
);

//registro de metodo deleteTipoMoneda
$server->register(
	'deleteTipoMoneda',   						
    array('id_tipo_moneda' => 'xsd:int'),         
    array('return' => 'xsd:string')   
);

// Get our posted data if the service is being consumed
// otherwise leave this data blank.                
$POST_DATA = isset($GLOBALS['HTTP_RAW_POST_DATA']) 
                ? $GLOBALS['HTTP_RAW_POST_DATA'] : '';

// pass our posted data (or nothing) to the soap service                    
$server->service($POST_DATA);                
exit();
?>