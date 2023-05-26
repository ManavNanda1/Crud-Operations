using PracProject.Repository.Repository;
using PracProject.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace PracProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IStudent, StudentServices>();
            container.RegisterType<ITeacher, TeacherServices>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}