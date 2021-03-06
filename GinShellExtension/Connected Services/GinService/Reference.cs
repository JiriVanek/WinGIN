﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GinShellExtension.GinService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GinService.IGinService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IGinService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/AddRepository", ReplyAction="http://tempuri.org/IGinService/AddRepositoryResponse")]
        bool AddRepository(string physicalDirectory, string mountpoint, string name, string commandline, bool performFullCheckout, bool createNew);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/AddRepository", ReplyAction="http://tempuri.org/IGinService/AddRepositoryResponse")]
        System.Threading.Tasks.Task<bool> AddRepositoryAsync(string physicalDirectory, string mountpoint, string name, string commandline, bool performFullCheckout, bool createNew);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/CreateNewRepository", ReplyAction="http://tempuri.org/IGinService/CreateNewRepositoryResponse")]
        bool CreateNewRepository(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/CreateNewRepository", ReplyAction="http://tempuri.org/IGinService/CreateNewRepositoryResponse")]
        System.Threading.Tasks.Task<bool> CreateNewRepositoryAsync(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/SetDefaultServer", ReplyAction="http://tempuri.org/IGinService/SetDefaultServerResponse")]
        bool SetDefaultServer(string alias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/SetDefaultServer", ReplyAction="http://tempuri.org/IGinService/SetDefaultServerResponse")]
        System.Threading.Tasks.Task<bool> SetDefaultServerAsync(string alias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/MountRepository", ReplyAction="http://tempuri.org/IGinService/MountRepositoryResponse")]
        bool MountRepository(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/MountRepository", ReplyAction="http://tempuri.org/IGinService/MountRepositoryResponse")]
        System.Threading.Tasks.Task<bool> MountRepositoryAsync(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UnmountRepository", ReplyAction="http://tempuri.org/IGinService/UnmountRepositoryResponse")]
        bool UnmountRepository(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UnmountRepository", ReplyAction="http://tempuri.org/IGinService/UnmountRepositoryResponse")]
        System.Threading.Tasks.Task<bool> UnmountRepositoryAsync(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/DeleteRepository", ReplyAction="http://tempuri.org/IGinService/DeleteRepositoryResponse")]
        void DeleteRepository(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/DeleteRepository", ReplyAction="http://tempuri.org/IGinService/DeleteRepositoryResponse")]
        System.Threading.Tasks.Task DeleteRepositoryAsync(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/DeleteServer", ReplyAction="http://tempuri.org/IGinService/DeleteServerResponse")]
        bool DeleteServer(string alias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/DeleteServer", ReplyAction="http://tempuri.org/IGinService/DeleteServerResponse")]
        System.Threading.Tasks.Task<bool> DeleteServerAsync(string alias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UnmmountAllRepositories", ReplyAction="http://tempuri.org/IGinService/UnmmountAllRepositoriesResponse")]
        bool UnmmountAllRepositories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UnmmountAllRepositories", ReplyAction="http://tempuri.org/IGinService/UnmmountAllRepositoriesResponse")]
        System.Threading.Tasks.Task<bool> UnmmountAllRepositoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/Login", ReplyAction="http://tempuri.org/IGinService/LoginResponse")]
        bool Login(string username, string password, string serverAlias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/Login", ReplyAction="http://tempuri.org/IGinService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password, string serverAlias);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/Logout")]
        void Logout();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/Logout")]
        System.Threading.Tasks.Task LogoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRepositoryList", ReplyAction="http://tempuri.org/IGinService/GetRepositoryListResponse")]
        string GetRepositoryList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRepositoryList", ReplyAction="http://tempuri.org/IGinService/GetRepositoryListResponse")]
        System.Threading.Tasks.Task<string> GetRepositoryListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/NewServer", ReplyAction="http://tempuri.org/IGinService/NewServerResponse")]
        bool NewServer(string alias, string web, string git);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/NewServer", ReplyAction="http://tempuri.org/IGinService/NewServerResponse")]
        System.Threading.Tasks.Task<bool> NewServerAsync(string alias, string web, string git);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRepositoryInfo", ReplyAction="http://tempuri.org/IGinService/GetRepositoryInfoResponse")]
        string GetRepositoryInfo(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRepositoryInfo", ReplyAction="http://tempuri.org/IGinService/GetRepositoryInfoResponse")]
        System.Threading.Tasks.Task<string> GetRepositoryInfoAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRemoteRepositoryInfo", ReplyAction="http://tempuri.org/IGinService/GetRemoteRepositoryInfoResponse")]
        string GetRemoteRepositoryInfo(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRemoteRepositoryInfo", ReplyAction="http://tempuri.org/IGinService/GetRemoteRepositoryInfoResponse")]
        System.Threading.Tasks.Task<string> GetRemoteRepositoryInfoAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UpdateRepository", ReplyAction="http://tempuri.org/IGinService/UpdateRepositoryResponse")]
        bool UpdateRepository(string repoName, GinClientLibrary.GinRepositoryData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UpdateRepository", ReplyAction="http://tempuri.org/IGinService/UpdateRepositoryResponse")]
        System.Threading.Tasks.Task<bool> UpdateRepositoryAsync(string repoName, GinClientLibrary.GinRepositoryData data);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/RetrieveFile")]
        void RetrieveFile(string repoName, string filepath);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/RetrieveFile")]
        System.Threading.Tasks.Task RetrieveFileAsync(string repoName, string filepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UploadFile", ReplyAction="http://tempuri.org/IGinService/UploadFileResponse")]
        void UploadFile(string repoName, string filepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UploadFile", ReplyAction="http://tempuri.org/IGinService/UploadFileResponse")]
        System.Threading.Tasks.Task UploadFileAsync(string repoName, string filepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UploadFileWithMessage", ReplyAction="http://tempuri.org/IGinService/UploadFileWithMessageResponse")]
        void UploadFileWithMessage(string repoName, string filepath, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/UploadFileWithMessage", ReplyAction="http://tempuri.org/IGinService/UploadFileWithMessageResponse")]
        System.Threading.Tasks.Task UploadFileWithMessageAsync(string repoName, string filepath, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/DownloadUpdateInfo", ReplyAction="http://tempuri.org/IGinService/DownloadUpdateInfoResponse")]
        void DownloadUpdateInfo(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/DownloadUpdateInfo", ReplyAction="http://tempuri.org/IGinService/DownloadUpdateInfoResponse")]
        System.Threading.Tasks.Task DownloadUpdateInfoAsync(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/DownloadAllUpdateInfo")]
        void DownloadAllUpdateInfo();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/DownloadAllUpdateInfo")]
        System.Threading.Tasks.Task DownloadAllUpdateInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRepositoryFileInfo", ReplyAction="http://tempuri.org/IGinService/GetRepositoryFileInfoResponse")]
        string GetRepositoryFileInfo(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRepositoryFileInfo", ReplyAction="http://tempuri.org/IGinService/GetRepositoryFileInfoResponse")]
        System.Threading.Tasks.Task<string> GetRepositoryFileInfoAsync(string repoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetFileInfo", ReplyAction="http://tempuri.org/IGinService/GetFileInfoResponse")]
        string GetFileInfo(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetFileInfo", ReplyAction="http://tempuri.org/IGinService/GetFileInfoResponse")]
        System.Threading.Tasks.Task<string> GetFileInfoAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetHistory", ReplyAction="http://tempuri.org/IGinService/GetHistoryResponse")]
        string GetHistory(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetHistory", ReplyAction="http://tempuri.org/IGinService/GetHistoryResponse")]
        System.Threading.Tasks.Task<string> GetHistoryAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsManagedPath", ReplyAction="http://tempuri.org/IGinService/IsManagedPathResponse")]
        bool IsManagedPath(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsManagedPath", ReplyAction="http://tempuri.org/IGinService/IsManagedPathResponse")]
        System.Threading.Tasks.Task<bool> IsManagedPathAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsManagedPathNonTerminating", ReplyAction="http://tempuri.org/IGinService/IsManagedPathNonTerminatingResponse")]
        bool IsManagedPathNonTerminating(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsManagedPathNonTerminating", ReplyAction="http://tempuri.org/IGinService/IsManagedPathNonTerminatingResponse")]
        System.Threading.Tasks.Task<bool> IsManagedPathNonTerminatingAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsBasePath", ReplyAction="http://tempuri.org/IGinService/IsBasePathResponse")]
        bool IsBasePath(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsBasePath", ReplyAction="http://tempuri.org/IGinService/IsBasePathResponse")]
        System.Threading.Tasks.Task<bool> IsBasePathAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/UpdateRepositories")]
        void UpdateRepositories(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/UpdateRepositories")]
        System.Threading.Tasks.Task UpdateRepositoriesAsync(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/UploadRepositories")]
        void UploadRepositories(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/UploadRepositories")]
        System.Threading.Tasks.Task UploadRepositoriesAsync(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/UploadRepositoriesWithMessage")]
        void UploadRepositoriesWithMessage(string[] filePaths, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/UploadRepositoriesWithMessage")]
        System.Threading.Tasks.Task UploadRepositoriesWithMessageAsync(string[] filePaths, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/DownloadFiles")]
        void DownloadFiles(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/DownloadFiles")]
        System.Threading.Tasks.Task DownloadFilesAsync(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/RemoveLocalContent")]
        void RemoveLocalContent(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/RemoveLocalContent")]
        System.Threading.Tasks.Task RemoveLocalContentAsync(string[] filePaths);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetGinCliVersion", ReplyAction="http://tempuri.org/IGinService/GetGinCliVersionResponse")]
        string GetGinCliVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetGinCliVersion", ReplyAction="http://tempuri.org/IGinService/GetGinCliVersionResponse")]
        System.Threading.Tasks.Task<string> GetGinCliVersionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRemoteRepositoryList", ReplyAction="http://tempuri.org/IGinService/GetRemoteRepositoryListResponse")]
        string GetRemoteRepositoryList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetRemoteRepositoryList", ReplyAction="http://tempuri.org/IGinService/GetRemoteRepositoryListResponse")]
        System.Threading.Tasks.Task<string> GetRemoteRepositoryListAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/SetEnvironmentVariables")]
        void SetEnvironmentVariables(string AppDataPath, string LocalAppDataPath);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGinService/SetEnvironmentVariables")]
        System.Threading.Tasks.Task SetEnvironmentVariablesAsync(string AppDataPath, string LocalAppDataPath);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, Action="http://tempuri.org/IGinService/EndSession")]
        void EndSession();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, Action="http://tempuri.org/IGinService/EndSession")]
        System.Threading.Tasks.Task EndSessionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsAlive", ReplyAction="http://tempuri.org/IGinService/IsAliveResponse")]
        bool IsAlive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/IsAlive", ReplyAction="http://tempuri.org/IGinService/IsAliveResponse")]
        System.Threading.Tasks.Task<bool> IsAliveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetServers", ReplyAction="http://tempuri.org/IGinService/GetServersResponse")]
        string GetServers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGinService/GetServers", ReplyAction="http://tempuri.org/IGinService/GetServersResponse")]
        System.Threading.Tasks.Task<string> GetServersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGinServiceChannel : GinShellExtension.GinService.IGinService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GinServiceClient : System.ServiceModel.ClientBase<GinShellExtension.GinService.IGinService>, GinShellExtension.GinService.IGinService {
        
        public GinServiceClient() {
        }
        
        public GinServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GinServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GinServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GinServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddRepository(string physicalDirectory, string mountpoint, string name, string commandline, bool performFullCheckout, bool createNew) {
            return base.Channel.AddRepository(physicalDirectory, mountpoint, name, commandline, performFullCheckout, createNew);
        }
        
        public System.Threading.Tasks.Task<bool> AddRepositoryAsync(string physicalDirectory, string mountpoint, string name, string commandline, bool performFullCheckout, bool createNew) {
            return base.Channel.AddRepositoryAsync(physicalDirectory, mountpoint, name, commandline, performFullCheckout, createNew);
        }
        
        public bool CreateNewRepository(string repoName) {
            return base.Channel.CreateNewRepository(repoName);
        }
        
        public System.Threading.Tasks.Task<bool> CreateNewRepositoryAsync(string repoName) {
            return base.Channel.CreateNewRepositoryAsync(repoName);
        }
        
        public bool SetDefaultServer(string alias) {
            return base.Channel.SetDefaultServer(alias);
        }
        
        public System.Threading.Tasks.Task<bool> SetDefaultServerAsync(string alias) {
            return base.Channel.SetDefaultServerAsync(alias);
        }
        
        public bool MountRepository(string repoName) {
            return base.Channel.MountRepository(repoName);
        }
        
        public System.Threading.Tasks.Task<bool> MountRepositoryAsync(string repoName) {
            return base.Channel.MountRepositoryAsync(repoName);
        }
        
        public bool UnmountRepository(string repoName) {
            return base.Channel.UnmountRepository(repoName);
        }
        
        public System.Threading.Tasks.Task<bool> UnmountRepositoryAsync(string repoName) {
            return base.Channel.UnmountRepositoryAsync(repoName);
        }
        
        public void DeleteRepository(string repoName) {
            base.Channel.DeleteRepository(repoName);
        }
        
        public System.Threading.Tasks.Task DeleteRepositoryAsync(string repoName) {
            return base.Channel.DeleteRepositoryAsync(repoName);
        }
        
        public bool DeleteServer(string alias) {
            return base.Channel.DeleteServer(alias);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteServerAsync(string alias) {
            return base.Channel.DeleteServerAsync(alias);
        }
        
        public bool UnmmountAllRepositories() {
            return base.Channel.UnmmountAllRepositories();
        }
        
        public System.Threading.Tasks.Task<bool> UnmmountAllRepositoriesAsync() {
            return base.Channel.UnmmountAllRepositoriesAsync();
        }
        
        public bool Login(string username, string password, string serverAlias) {
            return base.Channel.Login(username, password, serverAlias);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password, string serverAlias) {
            return base.Channel.LoginAsync(username, password, serverAlias);
        }
        
        public void Logout() {
            base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        public string GetRepositoryList() {
            return base.Channel.GetRepositoryList();
        }
        
        public System.Threading.Tasks.Task<string> GetRepositoryListAsync() {
            return base.Channel.GetRepositoryListAsync();
        }
        
        public bool NewServer(string alias, string web, string git) {
            return base.Channel.NewServer(alias, web, git);
        }
        
        public System.Threading.Tasks.Task<bool> NewServerAsync(string alias, string web, string git) {
            return base.Channel.NewServerAsync(alias, web, git);
        }
        
        public string GetRepositoryInfo(string name) {
            return base.Channel.GetRepositoryInfo(name);
        }
        
        public System.Threading.Tasks.Task<string> GetRepositoryInfoAsync(string name) {
            return base.Channel.GetRepositoryInfoAsync(name);
        }
        
        public string GetRemoteRepositoryInfo(string path) {
            return base.Channel.GetRemoteRepositoryInfo(path);
        }
        
        public System.Threading.Tasks.Task<string> GetRemoteRepositoryInfoAsync(string path) {
            return base.Channel.GetRemoteRepositoryInfoAsync(path);
        }
        
        public bool UpdateRepository(string repoName, GinClientLibrary.GinRepositoryData data) {
            return base.Channel.UpdateRepository(repoName, data);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateRepositoryAsync(string repoName, GinClientLibrary.GinRepositoryData data) {
            return base.Channel.UpdateRepositoryAsync(repoName, data);
        }
        
        public void RetrieveFile(string repoName, string filepath) {
            base.Channel.RetrieveFile(repoName, filepath);
        }
        
        public System.Threading.Tasks.Task RetrieveFileAsync(string repoName, string filepath) {
            return base.Channel.RetrieveFileAsync(repoName, filepath);
        }
        
        public void UploadFile(string repoName, string filepath) {
            base.Channel.UploadFile(repoName, filepath);
        }
        
        public System.Threading.Tasks.Task UploadFileAsync(string repoName, string filepath) {
            return base.Channel.UploadFileAsync(repoName, filepath);
        }
        
        public void UploadFileWithMessage(string repoName, string filepath, string message) {
            base.Channel.UploadFileWithMessage(repoName, filepath, message);
        }
        
        public System.Threading.Tasks.Task UploadFileWithMessageAsync(string repoName, string filepath, string message) {
            return base.Channel.UploadFileWithMessageAsync(repoName, filepath, message);
        }
        
        public void DownloadUpdateInfo(string repoName) {
            base.Channel.DownloadUpdateInfo(repoName);
        }
        
        public System.Threading.Tasks.Task DownloadUpdateInfoAsync(string repoName) {
            return base.Channel.DownloadUpdateInfoAsync(repoName);
        }
        
        public void DownloadAllUpdateInfo() {
            base.Channel.DownloadAllUpdateInfo();
        }
        
        public System.Threading.Tasks.Task DownloadAllUpdateInfoAsync() {
            return base.Channel.DownloadAllUpdateInfoAsync();
        }
        
        public string GetRepositoryFileInfo(string repoName) {
            return base.Channel.GetRepositoryFileInfo(repoName);
        }
        
        public System.Threading.Tasks.Task<string> GetRepositoryFileInfoAsync(string repoName) {
            return base.Channel.GetRepositoryFileInfoAsync(repoName);
        }
        
        public string GetFileInfo(string path) {
            return base.Channel.GetFileInfo(path);
        }
        
        public System.Threading.Tasks.Task<string> GetFileInfoAsync(string path) {
            return base.Channel.GetFileInfoAsync(path);
        }
        
        public string GetHistory(string path) {
            return base.Channel.GetHistory(path);
        }
        
        public System.Threading.Tasks.Task<string> GetHistoryAsync(string path) {
            return base.Channel.GetHistoryAsync(path);
        }
        
        public bool IsManagedPath(string filePath) {
            return base.Channel.IsManagedPath(filePath);
        }
        
        public System.Threading.Tasks.Task<bool> IsManagedPathAsync(string filePath) {
            return base.Channel.IsManagedPathAsync(filePath);
        }
        
        public bool IsManagedPathNonTerminating(string filePath) {
            return base.Channel.IsManagedPathNonTerminating(filePath);
        }
        
        public System.Threading.Tasks.Task<bool> IsManagedPathNonTerminatingAsync(string filePath) {
            return base.Channel.IsManagedPathNonTerminatingAsync(filePath);
        }
        
        public bool IsBasePath(string filePath) {
            return base.Channel.IsBasePath(filePath);
        }
        
        public System.Threading.Tasks.Task<bool> IsBasePathAsync(string filePath) {
            return base.Channel.IsBasePathAsync(filePath);
        }
        
        public void UpdateRepositories(string[] filePaths) {
            base.Channel.UpdateRepositories(filePaths);
        }
        
        public System.Threading.Tasks.Task UpdateRepositoriesAsync(string[] filePaths) {
            return base.Channel.UpdateRepositoriesAsync(filePaths);
        }
        
        public void UploadRepositories(string[] filePaths) {
            base.Channel.UploadRepositories(filePaths);
        }
        
        public System.Threading.Tasks.Task UploadRepositoriesAsync(string[] filePaths) {
            return base.Channel.UploadRepositoriesAsync(filePaths);
        }
        
        public void UploadRepositoriesWithMessage(string[] filePaths, string message) {
            base.Channel.UploadRepositoriesWithMessage(filePaths, message);
        }
        
        public System.Threading.Tasks.Task UploadRepositoriesWithMessageAsync(string[] filePaths, string message) {
            return base.Channel.UploadRepositoriesWithMessageAsync(filePaths, message);
        }
        
        public void DownloadFiles(string[] filePaths) {
            base.Channel.DownloadFiles(filePaths);
        }
        
        public System.Threading.Tasks.Task DownloadFilesAsync(string[] filePaths) {
            return base.Channel.DownloadFilesAsync(filePaths);
        }
        
        public void RemoveLocalContent(string[] filePaths) {
            base.Channel.RemoveLocalContent(filePaths);
        }
        
        public System.Threading.Tasks.Task RemoveLocalContentAsync(string[] filePaths) {
            return base.Channel.RemoveLocalContentAsync(filePaths);
        }
        
        public string GetGinCliVersion() {
            return base.Channel.GetGinCliVersion();
        }
        
        public System.Threading.Tasks.Task<string> GetGinCliVersionAsync() {
            return base.Channel.GetGinCliVersionAsync();
        }
        
        public string GetRemoteRepositoryList() {
            return base.Channel.GetRemoteRepositoryList();
        }
        
        public System.Threading.Tasks.Task<string> GetRemoteRepositoryListAsync() {
            return base.Channel.GetRemoteRepositoryListAsync();
        }
        
        public void SetEnvironmentVariables(string AppDataPath, string LocalAppDataPath) {
            base.Channel.SetEnvironmentVariables(AppDataPath, LocalAppDataPath);
        }
        
        public System.Threading.Tasks.Task SetEnvironmentVariablesAsync(string AppDataPath, string LocalAppDataPath) {
            return base.Channel.SetEnvironmentVariablesAsync(AppDataPath, LocalAppDataPath);
        }
        
        public void EndSession() {
            base.Channel.EndSession();
        }
        
        public System.Threading.Tasks.Task EndSessionAsync() {
            return base.Channel.EndSessionAsync();
        }
        
        public bool IsAlive() {
            return base.Channel.IsAlive();
        }
        
        public System.Threading.Tasks.Task<bool> IsAliveAsync() {
            return base.Channel.IsAliveAsync();
        }
        
        public string GetServers() {
            return base.Channel.GetServers();
        }
        
        public System.Threading.Tasks.Task<string> GetServersAsync() {
            return base.Channel.GetServersAsync();
        }
    }
}
