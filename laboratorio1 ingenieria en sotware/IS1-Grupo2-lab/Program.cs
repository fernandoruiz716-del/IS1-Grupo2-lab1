using System;

namespace IS1_Grupo2_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("           Laboratorio 1 Software                 ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Ver aporte de José Daniel");
                Console.WriteLine("2. Ver aporte de Fernando Josué");
                Console.WriteLine("3. Ver aporte de Alan Steven");
                Console.WriteLine("==================================================");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        MostrarAporteDaniel();
                        Pausar();
                        break;
                    case 2:
                        MostrarAporteFernando();
                        Pausar();
                        break;
                    case 3:
                        MostrarAportealan();
                        Pausar();
                        break;
                    
                }

            } while (opcion != 3);
        }

        static void MostrarAporteDaniel()
        {
            Console.Clear();
            string parte_dany = @"
                ======================================================================
                           DESARROLLO TRADICIONAL VS DESARROLLO ÁGIL
                                    José Daniel Sánchez
                

                ## Introducción
                El desarrollo de software ha evolucionado a lo largo de las décadas 
                adaptándose a las necesidades del mercado. Las dos metodologías 
                más relevantes son la tradicional y la ágil.

                ## Desarrollo Tradicional (Cascada)
                - Enfoque: Secuencial y lineal.
                - Sus Características son:
                  * Planificación rígida desde el inicio.
                  * Cambios costosos y difíciles de implementar una vez iniciado el proyecto.
                  * Documentación exhaustiva en cada fase.

                ## Desarrollo Ágil (Scrum / Kanban)
                - Enfoque: Iterativo e incremental.
                - Sus Características son:
                  * Prioriza el código funcional sobre la documentación excesiva.
                  * Entrega continua de valor en ciclos cortos (sprints).
                  * Alta colaboración con clientes y flexibilidad ante cambios.

                ## Ejemplos
                1. Ejemplo de Desarrollo Tradicional (Cascada): Sistema para un Banco.
                2. Ejemplo de Desarrollo Ágil (Scrum): Aplicación Móvil de Comida a Domicilio.

                ## Conclusión
                La elección entre una metodología tradicional o ágil depende de la 
                naturaleza del proyecto, la claridad de los requerimientos y la 
                necesidad de flexibilidad.
                ======================================================================
                ";
            Console.WriteLine(parte_dany);
        }

        static void MostrarAporteFernando()
        {
            Console.Clear();
            string parte_fernando = @"
                ======================================================================
                           FALLO PENITENCIARIO DE WASHINGTON (2002 - 2015)
                                           Fernando Josué
                

                El fallo penitenciario de Washington se refiere a un grave error[cite: 1]
                informático y operativo dentro del Departamento de Correcciones[cite: 1]
                de Washington (WA DOC)[cite: 1]. Durante 13 años, un bug de software provocó[cite: 1]
                la liberación anticipada e indebida de miles de reclusos[cite: 1].

                ----------------------------------------------------------------------
                ## ORIGEN Y CRONOLOGÍA DE LA FALLA
                ----------------------------------------------------------------------
                * 2002 - El origen del error: Una sentencia del Tribunal Supremo exigió[cite: 1]
                  aplicar créditos de tiempo servido de forma diferente[cite: 1]. Al actualizar 
                  el software, se introdujo un fallo de programación (bug)[cite: 1].
                * 2012 - La advertencia omitida: Un empleado y la familia de una víctima[cite: 1]
                  notificaron la inconsistencia, pero la corrección fue postergada[cite: 1].
                * 2015 - Descubrimiento y corrección: La alta directiva tomó conocimiento[cite: 1]
                  directo y procedió a reparar el código del sistema informático[cite: 1].

                ----------------------------------------------------------------------
                ## IMPACTO Y CONSECUENCIAS
                ----------------------------------------------------------------------
                * Liberaciones prematuras: Más de 3,200 reclusos fueron liberados antes[cite: 1]
                  de cumplir sus condenas legalmente correspondientes[cite: 1].
                * Reincidencia e incidentes graves: Algunos exreclusos cometieron nuevos[cite: 1]
                  delitos violentos durante el tiempo en que debían estar en prisión[cite: 1].
                * Operativo de recaptura: El estado tuvo que rastrear y reingresar a[cite: 1]
                  cientos de personas liberadas por error[cite: 1].

                ----------------------------------------------------------------------
                ## LECCIONES Y REFORMAS
                ----------------------------------------------------------------------
                * Dimisión de autoridades: Renuncia de altos funcionarios del WA DOC[cite: 1].
                * Auditoría de TI: Revisión técnica profunda e independiente de todos[cite: 1]
                  los algoritmos del cálculo de sentencias[cite: 1].
                * Supervisión externa: Creación de organismos de auditoría y la figura[cite: 1]
                  del Ombudsperson para vigilar las operaciones[cite: 1].
                ======================================================================
                ";
            Console.WriteLine(parte_fernando);
        }

        static void MostrarAportealan()
        {
            Console.Clear();
            string parte_ala= @"
                ======================================================================
                       LOS 4 VALORES Y 12 PRINCIPIOS DEL MANIFIESTO ÁGIL
                                       AAlan Steven
                

                Creado en 2001 por 17 críticos de las metodologías tradicionales, 
                el Manifiesto Ágil estableció una nueva forma de desarrollar software 
                basada en la adaptabilidad y el valor humano.

                ----------------------------------------------------------------------
                ## LOS 4 VALORES FUNDAMENTALES
                ----------------------------------------------------------------------
                1. Individuos e interacciones sobre procesos y herramientas.
                2. Software funcionando sobre documentación exhaustiva.
                3. Colaboración con el cliente sobre negociación contractual.
                4. Respuesta ante el cambio sobre el seguimiento de un plan.

                ----------------------------------------------------------------------
                ## LOS 12 PRINCIPIOS ÁGILES
                ----------------------------------------------------------------------
                1. Satisfacción del cliente mediante la entrega temprana y continua.
                2. Aceptación de requisitos cambiantes, incluso en etapas tardías.
                3. Entrega frecuente de software funcional (semanas o meses).
                4. Trabajo conjunto y diario entre negocio y desarrolladores.
                5. Construir proyectos en torno a individuos motivados.
                6. Conversación cara a cara como el método más eficiente de comunicación.
                7. El software funcionando es la medida principal de progreso.
                8. Promoción del desarrollo sostenible y ritmo constante.
                9. Atención continua a la excelencia técnica y buen diseño.
                10. La simplicidad (maximizar la cantidad de trabajo no realizado).
                11. Equipos autoorganizados generan las mejores arquitecturas.
                12. Reflexión periódica del equipo para ajustar y perfeccionar el comportamiento.
                ======================================================================
                ";
            Console.WriteLine(parte_ala);
        }

        static void Pausar()
        {
            Console.WriteLine("Presione cualquier tecla para regresar al menú");
            Console.ReadKey();
        }
    }
}









