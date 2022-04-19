﻿using Entidades.Diseno;
using Entidades.Diseno.Marcadores;
using System;
    public class DTelas

                using (SqlConnection cn = DConexion.obtenerConexion())
                    comando.ExecuteNonQuery();
                }
                List<ETelas> lstPrendas = new List<ETelas>();

                using (SqlConnection cn = DConexion.obtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("diseno_telas_consultar_ultimo_registro", cn) { CommandType = CommandType.StoredProcedure };
                    cn.Open();
                    SqlDataReader rd = comando.ExecuteReader(CommandBehavior.SingleResult);
                    while (rd.Read())
                    {
                        lstPrendas.Add(new ETelas
                        {
                            id_tela = DBNull.Value.Equals(rd["id_tela"]) ? 0 : Convert.ToInt32(rd["id_tela"]),
                           
                                });
                    }

                }
                int valor = 0;
                foreach(ETelas itm in lstPrendas)
                {
                    valor = itm.id_tela;
                }
                return valor;
                string value = e.InnerException.ToString();
        public static int SetActualizaDisenoTelas(ETelas actualiza) //PROCESO PARA ACTUALIZACION DE REGISTROS PARA LA TABLA DISENO_FAMILIA_PRENDAS
        {
            try
            {

                using (SqlConnection cn = DConexion.obtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("diseno_tela_actualizar", cn) { CommandType = CommandType.StoredProcedure };
                    comando.Parameters.Add("@ID_TELA", SqlDbType.NVarChar).Value = actualiza.id_tela;
                    comando.Parameters.Add("@TIPO", SqlDbType.Int).Value = actualiza.tipo;
                    comando.ExecuteNonQuery();
                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public static void SetEliminarImagenTela(int id_tela)
        {
            //actualiza el campo imagen a vacio, del registro de tela
            try
        }
            public static void SetHabilitarDeshabilitarTelas(int id_material, int estatus) //PROCESO PARA HABILITAR/DESHABILITAR REGISTROS PARA LA TABLA DISENO MATERIAL
        {
        {
            { 
                        descripcion = Convert.ToString(rd["descripcion"]),
                        id_familia_composicion = Convert.ToInt32(rd["id_familia_composicion"]),
                        id_estampado = Convert.ToInt32(rd["id_estampado"]),
                        id_proveedor = Convert.ToInt32(rd["id_proveedor"]),
                        clave_proveedor = Convert.ToString(rd["clave_proveedor"]),
                        id_color = Convert.ToInt32(rd["id_color"]),
                        ancho_tela = Convert.ToDouble(rd["ancho_tela"]),
                        imagen = Convert.ToString(rd["imagen"]),
                        observaciones = rd["observaciones"].ToString(),
                        estatus = Convert.ToInt32(rd["estatus"]),
                        auxestatus = rd["auxestatus"].ToString(),
                        estatus_tela = Convert.ToInt32(rd["estatus_tela"]),
                        prueba_encogimiento_largo = Convert.ToDouble(rd["prueba_encogimiento_largo"]),
                        prueba_encogimiento_ancho = Convert.ToDouble(rd["prueba_encogimiento_ancho"]),
                        auxtipo = rd["auxtipo"].ToString(),
                        auxid_familia_composicion = rd["auxid_familia_composicion"].ToString(),
                        auxid_estampado = rd["auxid_estampado"].ToString(),
                        auxid_proveedor = rd["auxid_proveedor"].ToString(),
                        auxid_color = rd["auxid_color"].ToString(),
                     });
                return lstPrendas;
                string error = e.InnerException.ToString();
                return new List<ETelas>();
            }
        }
        {
                        tipo_material = Convert.ToString(rd["tipo_material"]),
                        clasificacion = Convert.ToString(rd["clasificacion"]),
                        estatus = Convert.ToInt32(rd["estatus"]),
                        auxdescrip = rd["auxdescrip"].ToString(),
                    });


        
        public static List<EFamiliaComposicioncombo> GetLlenarCombofamiliacomposicion() //PROCESO PARA CONSULTAR INFORMACION DE LA TABLA DISENO fFAMILIA COMPOSICION TIPO, SE UTILIZA PARA LLENAR LOS COMBOS RELACIONADOS EN LA FORMA MATERIAL
        {
                    });
            }
           catch(Exception e )
            {
                string s = e.InnerException.ToString();
                return new List<EFamiliaComposicioncombo>();
            }
            }


        public static List<EComprasProveedores> GetLlenarComboComprasProveedores() //PROCESO PARA CONSULTAR INFORMACION DE LA TABLA COMPRAS PROVEEDOR, SE UTILIZA PARA LLENAR LOS COMBOS RELACIONADOS EN LA FORMA MATERIAL
        {
                        nomenclatura_tela = Convert.ToString(rd["nomenclatura_tela"]),
                        estatus = Convert.ToInt32(rd["estatus"]),
                        auxdescrip = rd["auxdescrip"].ToString(),
                    });

        public static List<EColores> GetLlenarComboDisenoColores() //PROCESO PARA CONSULTAR INFORMACION DE LA TABLA DISENO COLORES, SE UTILIZA PARA LLENAR LOS COMBOS RELACIONADOS EN LA FORMA MATERIAL
        {
                        estatus = Convert.ToInt32(rd["estatus"]),
                        auxdescrip = rd["auxdescrip"].ToString(),
                    });


        public static List<EMaterialesProcesoscombo> GetLlenarComboMaterialesProcesos() //PROCESO PARA CONSULTAR INFORMACION DE LA TABLA DISENO COLORES, SE UTILIZA PARA LLENAR LOS COMBOS RELACIONADOS EN LA FORMA MATERIAL
        {
                        auxdescrip = rd["auxdescrip"].ToString(),
                    });


        public static List<EEstampados> GetLlenarCombodisenoestampado() //PROCESO PARA CONSULTAR INFORMACION DE LA TABLA DISENO COLORES, SE UTILIZA PARA LLENAR LOS COMBOS RELACIONADOS EN LA FORMA MATERIAL
        {
                        auxdescrip = rd["auxdescrip"].ToString(),
                    });




        public static List<EUnidadesMedidas> GetLlenarComboUnidadMedida() //PROCESO PARA CONSULTAR INFORMACION DE LA TABLA DISENO COLORES, SE UTILIZA PARA LLENAR LOS COMBOS RELACIONADOS EN LA FORMA MATERIAL
        {
                        estatus = Convert.ToInt32(rd["estatus"]),
                        auxdescrip = rd["auxdescrip"].ToString(),
                    });